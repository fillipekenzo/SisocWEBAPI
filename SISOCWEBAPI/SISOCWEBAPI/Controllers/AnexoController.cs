using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SISOC.Business.Interface;
using SISOC.Business.Models;
using SISOCWEBAPI.DTOs;
using static System.Net.Mime.MediaTypeNames;

namespace SISOCWEBAPI.Controllers
{
	[Route("sisocwebapi/v1/[controller]")]
	public class AnexoController : MainController
	{
		private readonly IWebHostEnvironment _env;
		private readonly IAnexoRepository _anexoRepository;
		private readonly IMapper _mapper;
		public AnexoController(INotificador notificador,
							IAnexoRepository anexoRepository,
							IMapper mapper,
							IWebHostEnvironment env) : base(notificador)
		{
			_env = env;
			_anexoRepository = anexoRepository;
			_mapper = mapper;
		}
		[HttpGet]
		public async Task<ActionResult<List<Anexo>>> Get()
		{
			var modulos = await _anexoRepository.ObterTodos();
			return CustomResponse(modulos.ToList());
		}


		[HttpGet]
		[Route("getbyid")]
		public async Task<ActionResult<Anexo>> GetByID(int id)
		{
			Anexo anexo = await _anexoRepository.ObterPorID(id);
			return CustomResponse(anexo);
		}

		[HttpPost]
		public async Task<IActionResult> Post(AnexoDTO anexoDTO, IFormFile file)
		{
			try
			{
				anexoDTO.Nome = file.FileName;
				MemoryStream ms = new MemoryStream();
				file.CopyTo(ms);
				anexoDTO.AnexoDados = ms.ToArray();
				ms.Close();
				ms.Dispose();
				await _anexoRepository.Adicionar(_mapper.Map<Anexo>(anexoDTO));
				return CustomResponse();
			}
			catch (Exception ex)
			{
				NotificarErro(ex.Message);
				return CustomResponse();
			}
		}

		[HttpPost]
		[Route("getAnexo")]
		public ActionResult GetAnexo()
		{
			try
			{
				Anexo img = _anexoRepository.ObterTodos().Result.FirstOrDefault();
				if (img != null)
				{
					string imageBase64Data = Convert.ToBase64String(img.AnexoDados);

					string imageDataURL =
						string.Format("data:image/jpg;base64,{0}", imageBase64Data);
					img.AnexoURL = imageDataURL;
					return CustomResponse(img);
				}
				return CustomResponse();

			}
			catch (Exception ex)
			{
				NotificarErro(ex.Message);
				return CustomResponse();
			}
		}

		[HttpPut]
		public async Task<IActionResult> Put([FromBody] AnexoDTO anexoDTO)
		{
			try
			{
				await _anexoRepository.Atualizar(_mapper.Map<Anexo>(anexoDTO));
				return CustomResponse();
			}
			catch (Exception ex)
			{
				NotificarErro(ex.Message);
				return CustomResponse();
			}
		}

		[HttpDelete]
		public async Task<IActionResult> Delete(int id)
		{
			try
			{
				return CustomResponse(_anexoRepository.Remover(id));
			}
			catch (Exception ex)
			{
				NotificarErro(ex.Message);
				return CustomResponse();
			}
		}
	}
}
