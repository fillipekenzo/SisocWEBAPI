using Microsoft.Extensions.Configuration;
using SISOC.Business.Interface;
using SISOC.Business.Models;
using SISOC.Util.Consulta;
using SISOC.Util.Consulta.Filtros;
using SISOC.Util.Mail;
using System.Net.Mail;

namespace SISOC.Business.Service
{
	public class OcorrenciaService : BaseService, IOcorrenciaService
	{
		private readonly IOcorrenciaRepository _ocorrenciaRepository;
		private readonly IUsuarioRepository _usuarioRepository;
		private readonly IAnexoRepository _anexoRepository;
		private readonly ITipoUsuarioRepository _tipoUsuarioRepository;
		private Consulta<Ocorrencia> _consulta;
		private readonly IConfiguration _configuration;
		private readonly Email _email;

		public OcorrenciaService(INotificador notificador,
			IAnexoRepository anexoRepository,
			IConfiguration configuration,
			IOcorrenciaRepository ocorrenciaRepository,
			ITipoUsuarioRepository tipoUsuarioRepository,
			IUsuarioRepository usuarioRepository) : base(notificador)
		{
			_consulta = new Consulta<Ocorrencia>();
			_anexoRepository = anexoRepository;
			_ocorrenciaRepository = ocorrenciaRepository;
			_usuarioRepository = usuarioRepository;
			_tipoUsuarioRepository = tipoUsuarioRepository;
			_configuration = configuration;
			_email = new Email(configuration);
		}

		public Task<bool> Post(Ocorrencia ocorrencia)
		{
			throw new NotImplementedException();
		}

		public async Task EnviarEmailAtendimentoSetor(Ocorrencia ocorrencia)
		{
			try
			{
				var tipoUsuarioAtendimento = _tipoUsuarioRepository.Buscar(t => t.Nome.ToUpper().Contains("ATENDIMENTO")).Result.FirstOrDefault();
				var usuariosAtendimentoSetor = _usuarioRepository.Buscar(u => u.TipoUsuarioID == tipoUsuarioAtendimento.TipoUsuarioID && u.SetorID == ocorrencia.SetorID).Result;
				if (usuariosAtendimentoSetor.Count() > 0)
				{
					var listaEmails = new List<string>();
					foreach (var usuario in usuariosAtendimentoSetor)
					{
						listaEmails.Add(usuario.Email);
					}
					string bodyHTML = $"<div dir=\"ltr\"><div class=\"gmail_quote\"><strong><h1 style=\"font-family:&quot;Arial&quot;,&quot;sans-serif&quot;\">Ocorrência: #{ocorrencia.OcorrenciaID} - {ocorrencia.Assunto} foi adicionada ao seu Setor na Data: {DateTime.UtcNow.ToString("dd/MM/yyyy")} - {DateTime.UtcNow.ToShortTimeString()}</h1></strong></div></br><a style=\"font-family:&quot;Arial&quot;,&quot;sans-serif&quot;\" href=\"https://sisocsite.vercel.app/#/ocorrencia/visualizar/{ocorrencia.OcorrenciaID}\">Acesse o sistema para visualizar</a></div>";

					string emailBody = $"Ocorrência: #{ocorrencia.OcorrenciaID} - {ocorrencia.Assunto} foi adicionada ao seu Setor na Data: {DateTime.UtcNow.ToShortDateString()} - {DateTime.UtcNow.ToShortTimeString()}. Acesse o sistema para verificar.";
					_email.Enviar(listaEmails, new List<string>() { }, new List<string>() { }, "SISOC - Nova Ocorrência adicionada", bodyHTML);
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		public async Task EnviarEmailEditarOcorrencia(Ocorrencia ocorrencia, string situacaoNova)
		{
			try
			{
				var usuarioCadastro = _usuarioRepository.ObterPorID(ocorrencia.UsuarioCadastroID).Result;
				var usuarioAtribuido = _usuarioRepository.ObterPorID(ocorrencia.UsuarioAtribuidoID.Value).Result;

				if (usuarioCadastro != null)
				{
					string bodyHTML = $"<div dir=\"ltr\"><div class=\"gmail_quote\"><strong><h1 style=\"font-family:&quot;Arial&quot;,&quot;sans-serif&quot;\">A situação da Ocorrência: #{ocorrencia.OcorrenciaID} - {ocorrencia.Assunto}</div></br><div class=\"gmail_quote\"><strong><h1 style=\"font-family:&quot;Arial&quot;,&quot;sans-serif&quot;\">Foi alterada para {situacaoNova} por {usuarioAtribuido.Nome} na Data: {DateTime.UtcNow.ToString("dd/MM/yyyy")} - {DateTime.UtcNow.ToShortTimeString()}</h1></strong></div></br><a style=\"font-family:&quot;Arial&quot;,&quot;sans-serif&quot;\" href=\"https://sisocsite.vercel.app/#/ocorrencia/visualizar/{ocorrencia.OcorrenciaID}\">Acesse o sistema para visualizar</a></div>";

					_email.Enviar(new List<string>() { usuarioCadastro.Email }, new List<string>() { }, new List<string>() { }, "SISOC - Ocorrência Atualizada", bodyHTML);
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		public async Task<IEnumerable<Ocorrencia>> BuscarComFiltro(OcorrenciaFiltros concurso)
		{
			IEnumerable<Ocorrencia> ocorrencias = await _ocorrenciaRepository.ObterTodos();
			return _consulta.Filtrar(ocorrencias, concurso);
		}

	}
}
