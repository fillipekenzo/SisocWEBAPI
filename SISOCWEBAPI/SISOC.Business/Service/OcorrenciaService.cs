using SISOC.Business.Interface;
using SISOC.Business.Models;

namespace SISOC.Business.Service
{
	public class OcorrenciaService : BaseService, IOcorrenciaService
	{
		private readonly IAnexoRepository _anexoRepository;

		public OcorrenciaService(INotificador notificador,
			IAnexoRepository anexoRepository) : base(notificador)
		{
			_anexoRepository = anexoRepository;
		}

		public Task<bool> Post(Ocorrencia ocorrencia)
		{
			throw new NotImplementedException();
		}

	}
}
