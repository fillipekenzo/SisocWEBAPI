using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SISOC.Business.Interface;
using SISOC.Business.Models;
using SISOCWEBAPI.DTOs;

namespace SISOCWEBAPI.Controllers
{
	[Route("sisocwebapi/v1/[controller]")]
	public class SetorController : MainController
	{
		private readonly IWebHostEnvironment _env;
		private readonly ISetorRepository _setorRepository;
		private readonly IMapper _mapper;
		public SetorController(INotificador notificador,
							ISetorRepository setorRepository,
							IMapper mapper,
							IWebHostEnvironment env) : base(notificador)
		{
			_env = env;
			_setorRepository = setorRepository;
			_mapper = mapper;
		}
		[HttpGet]
		public async Task<ActionResult<List<Setor>>> Get()
		{
			var modulos = await _setorRepository.ObterTodos();
			return CustomResponse(modulos.ToList());
		}


		[HttpGet]
		[Route("getbyid")]
		public async Task<ActionResult<Setor>> GetByID(int id)
		{
			Setor setor = await _setorRepository.ObterPorID(id);
			return CustomResponse(setor);
		}

		[HttpPost]
		public async Task<IActionResult> Post([FromBody] SetorDTO setor)
		{
			try
			{
				await _setorRepository.Adicionar(_mapper.Map<Setor>(setor));
				return CustomResponse();
			}
			catch (Exception ex)
			{
				NotificarErro(ex.Message);
				return CustomResponse();
			}
		}

		[HttpPut]
		public async Task<IActionResult> Put([FromBody] SetorDTO setor)
		{
			try
			{
				await _setorRepository.Atualizar(_mapper.Map<Setor>(setor));
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
				return CustomResponse(_setorRepository.Remover(id));
			}
			catch (Exception ex)
			{
				NotificarErro(ex.Message);
				return CustomResponse();
			}
		}
	}
}
