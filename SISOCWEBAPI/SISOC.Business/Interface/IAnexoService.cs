using Microsoft.AspNetCore.Http;
using SISOC.Business.Models;

namespace SISOC.Business.Interface
{
	public interface IAnexoService
	{
		Task<bool> UploadImagem(Anexo anexo, IFormFile formFile);
		Task<Anexo> GetImagem(int anexoID);
	}
}

