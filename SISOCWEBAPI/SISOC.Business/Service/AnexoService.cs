using Microsoft.AspNetCore.Http;
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

		public async Task<Anexo> GetImagem(int anexoID)
		{
			try
			{
				Anexo img = _anexoRepository.ObterPorID(anexoID).Result;
				if (img != null)
				{
					string imageBase64Data = Convert.ToBase64String(img.AnexoDados);
					string imageDataURL =
						string.Format($"data:{img.TipoAnexo};base64,{imageBase64Data}");
					img.AnexoURL = imageDataURL;
					return await Task.FromResult(img);
				}
				return await Task.FromResult(img);

			}
			catch (Exception ex)
			{
				throw new Exception("Falha ao realizar download do anexo");
			}
		}

		public async Task<bool> UploadImagem(Anexo anexo, IFormFile formFile)
		{
			try
			{

				MemoryStream ms = new MemoryStream();
				formFile.CopyTo(ms);
				anexo.Nome = formFile.FileName;
				anexo.TipoAnexo = formFile.ContentType;
				anexo.AnexoDados = ms.ToArray();
				ms.Close();
				ms.Dispose();
				await _anexoRepository.Adicionar(anexo);
				return true;
			}
			catch (Exception ex)
			{
				throw new Exception("Falha ao realizar upload do anexo");
				return false;
			}
		}
	}
}
