using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SISOC.Business.Interface;
using SISOC.Business.Models;
using SISOCWEBAPI.DTOs;

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
		public async Task<IActionResult> Post([FromBody] AnexoDTO anexoDTO)
		{
			try
			{
				await _anexoRepository.Adicionar(_mapper.Map<Anexo>(anexoDTO));
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
