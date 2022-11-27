using SISOC.Business.Models;

namespace SISOC.Business.Interface
{
	public interface IAnexoService
	{
		Task<bool> UploadImagem();
		Task<Anexo> GetImagem();
	}
}

