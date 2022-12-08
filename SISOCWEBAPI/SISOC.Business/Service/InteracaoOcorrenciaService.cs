using Microsoft.Extensions.Configuration;
using SISOC.Business.Interface;
using SISOC.Business.Models;
using SISOC.Util.Consulta;
using SISOC.Util.Consulta.Filtros;
using SISOC.Util.Mail;
using System.Net.Mail;

namespace SISOC.Business.Service
{
	public class InteracaoOcorrenciaService : BaseService, IInteracaoOcorrenciaService
	{
		private readonly IOcorrenciaRepository _ocorrenciaRepository;
		private readonly IUsuarioRepository _usuarioRepository;
		private readonly IAnexoRepository _anexoRepository;
		private readonly ITipoUsuarioRepository _tipoUsuarioRepository;
		private Consulta<Ocorrencia> _consulta;
		private readonly IConfiguration _configuration;
		private readonly Email _email;

		public InteracaoOcorrenciaService(INotificador notificador,
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
			_configuration = configuration;
			_email = new Email(configuration);
		}

		public Task<bool> Post(Ocorrencia ocorrencia)
		{
			throw new NotImplementedException();
		}

		public async Task EnviarEmailAtendimentoSetorInteracaoOcorrencia(InteracaoOcorrencia interacaoOcorrencia)
		{
			try
			{
				var ocorrencia = _ocorrenciaRepository.ObterPorID(interacaoOcorrencia.OcorrenciaID).Result;
				int userEmailID = ocorrencia.UsuarioAtribuidoID == interacaoOcorrencia.UsuarioID ? ocorrencia.UsuarioCadastroID : ocorrencia.UsuarioAtribuidoID.Value;

				var usuariosEnvolvidosInteracao = _usuarioRepository.ObterPorID(userEmailID).Result;
				if (usuariosEnvolvidosInteracao != null)
				{
					var listaEmails = new List<string>();
					string bodyHTML = $"<div dir=\"ltr\"><div class=\"gmail_quote\"><strong><h1 style=\"font-family:&quot;Arial&quot;,&quot;sans-serif&quot;\">Ocorrência: #{ocorrencia.OcorrenciaID} - {ocorrencia.Assunto}</h1></strong></div></br><h2 style=\"font-family:&quot;Arial&quot;,&quot;sans-serif&quot;\">Interação Adicionada na Data: {DateTime.UtcNow.ToShortDateString()} - {DateTime.UtcNow.ToShortTimeString()}: #{interacaoOcorrencia.InteracaoOcorrenciaID} - {interacaoOcorrencia.Assunto}: {interacaoOcorrencia.Descricao} </h2></br><a style=\"font-family:&quot;Arial&quot;,&quot;sans-serif&quot;\" href=\"https://sisocsite.vercel.app/#/ocorrencia/visualizar/{ocorrencia.OcorrenciaID}\">Acesse o sistema para visualizar</a></div>";

					//string emailBody = $"Ocorrência: #{ocorrencia.OcorrenciaID} - {ocorrencia.Assunto} foi adicionada ao seu Setor na Data: {DateTime.UtcNow.ToShortDateString()} - {DateTime.UtcNow.ToShortTimeString()}. Acesse o sistema para verificar.";
					_email.Enviar(new List<string>() { usuariosEnvolvidosInteracao.Email }, new List<string>() { }, new List<string>() { }, "SISOC - Interação na ocorrência adicionada", bodyHTML);
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

	}
}
