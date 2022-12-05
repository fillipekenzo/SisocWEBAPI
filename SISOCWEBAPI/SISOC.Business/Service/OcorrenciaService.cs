using SISOC.Business.Interface;
using SISOC.Business.Models;
using SISOC.Util.Consulta;
using SISOC.Util.Consulta.Filtros;

namespace SISOC.Business.Service
{
	public class OcorrenciaService : BaseService, IOcorrenciaService
	{
		private readonly IOcorrenciaRepository _ocorrenciaRepository;
		private readonly IAnexoRepository _anexoRepository;
		private Consulta<Ocorrencia> _consulta;

		public OcorrenciaService(INotificador notificador,
			IAnexoRepository anexoRepository,
			IOcorrenciaRepository ocorrenciaRepository) : base(notificador)
		{
            _consulta = new Consulta<Ocorrencia>();
			_anexoRepository = anexoRepository;
			_ocorrenciaRepository = ocorrenciaRepository;
		}

		public Task<bool> Post(Ocorrencia ocorrencia)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<Ocorrencia>> BuscarComFiltro(OcorrenciaFiltros concurso)
		{
			IEnumerable<Ocorrencia> ocorrencias = await _ocorrenciaRepository.ObterTodos();
			return _consulta.Filtrar(ocorrencias, concurso);
		}

	}
}
