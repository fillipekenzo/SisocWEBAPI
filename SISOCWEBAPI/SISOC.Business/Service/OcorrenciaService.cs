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
			var tipoUsuarioAtendimento = _tipoUsuarioRepository.Buscar(t => t.Nome.ToUpper().Contains("ATENDIMENTO")).Result.FirstOrDefault();
			var usuariosAtendimentoSetor = _usuarioRepository.Buscar(u => u.TipoUsuarioID == tipoUsuarioAtendimento.TipoUsuarioID && u.SetorID == ocorrencia.SetorID).Result;
			if(usuariosAtendimentoSetor != null)
			{
				LinkedResource inlineIFMS = _email.CarregarLogoIFMS();
				List<LinkedResource> linkedResources = new List<LinkedResource>() { { inlineIFMS } };
				foreach (var usuario in usuariosAtendimentoSetor)
				{
					var model = new
					{
						Email = usuario.Email,
						Ocorrencia = ocorrencia,
						Data = DateTime.Now.ToShortDateString(),
						Hora = DateTime.Now.ToShortTimeString(),
						CidIFMS = inlineIFMS.ContentId,
					};
					string template = _email.GerarTemplate("EmailNotificacaoOcorrencia.cshtml");
					string emailBody = await _email.RunCompile(template, model);
					_email.Enviar(new List<string>() { usuario.Email }, new List<string>() { }, new List<string>() { }, "Teste", emailBody, linkedResources);

				}
			}

		}

		public async Task<IEnumerable<Ocorrencia>> BuscarComFiltro(OcorrenciaFiltros concurso)
		{
			IEnumerable<Ocorrencia> ocorrencias = await _ocorrenciaRepository.ObterTodos();
			return _consulta.Filtrar(ocorrencias, concurso);
		}

	}
}
