using SISOC.Business.Interface;
using SISOC.Business.Models;

namespace SISOC.Business.Service
{
	public class AnexoService : BaseService, IAnexoService
	{
		private readonly IAnexoRepository _anexoRepository;

		public AnexoService(INotificador notificador,
			IAnexoRepository anexoRepository) : base(notificador)
		{
			_anexoRepository = anexoRepository;
		}

		public Task<Anexo> GetImagem()
		{
			throw new NotImplementedException();
		}

		public Task<bool> UploadImagem()
		{
			throw new NotImplementedException();
		}
	}
}
