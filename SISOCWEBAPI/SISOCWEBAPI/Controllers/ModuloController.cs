using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SISOC.Business.Interface;
using SISOC.Business.Models;
using SISOCWEBAPI.DTOs;

namespace SISOCWEBAPI.Controllers
{
	[Route("sisocwebapi/v1/[controller]")]
	public class ModuloController : MainController
	{
		private readonly IWebHostEnvironment _env;
		private readonly IModuloRepository _moduloRepository;
		private readonly IMapper _mapper;
		public ModuloController(INotificador notificador,
							IModuloRepository moduloRepository,
							IMapper mapper,
							IWebHostEnvironment env) : base(notificador)
		{
			_env = env;
			_moduloRepository = moduloRepository;
			_mapper = mapper;
		}
		[HttpGet]
		public async Task<ActionResult<List<Modulo>>> Get()
		{
			var modulos = await _moduloRepository.ObterTodos();
			return CustomResponse(modulos.ToList());
		}


		[HttpGet]
		[Route("getbyid")]
		public async Task<ActionResult<Modulo>> GetByID(int id)
		{
			Modulo modulo = await _moduloRepository.ObterPorID(id);
			return CustomResponse(modulo);
		}

		[HttpPost]
		public async Task<IActionResult> Post([FromBody] ModuloDTO modulo)
		{
			try
			{
				await _moduloRepository.Adicionar(_mapper.Map<Modulo>(modulo));
				return CustomResponse();
			}
			catch (Exception ex)
			{
				NotificarErro(ex.Message);
				return CustomResponse();
			}
		}

		[HttpPut]
		public async Task<IActionResult> Put([FromBody] ModuloDTO modulo)
		{
			try
			{
				await _moduloRepository.Atualizar(_mapper.Map<Modulo>(modulo));
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
				return CustomResponse(_moduloRepository.Remover(id));
			}
			catch (Exception ex)
			{
				NotificarErro(ex.Message);
				return CustomResponse();
			}
		}
	}
}
