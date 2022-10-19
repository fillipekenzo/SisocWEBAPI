using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SISOC.Business.Interface;
using SISOC.Business.Models;
using SISOCWEBAPI.DTOs;

namespace SISOCWEBAPI.Controllers
{
	[Route("sisocwebapi/v1/[controller]")]
	public class SubmenuController : MainController
	{
		private readonly IWebHostEnvironment _env;
		private readonly ISubmenuRepository _submenuRepository;
		private readonly IMapper _mapper;
		public SubmenuController(INotificador notificador,
							ISubmenuRepository menuRepository,
							IMapper mapper,
							IWebHostEnvironment env) : base(notificador)
		{
			_env = env;
			_submenuRepository = menuRepository;
			_mapper = mapper;
		}
		[HttpGet]
		public async Task<ActionResult<List<Submenu>>> Get()
		{
			var menus = await _submenuRepository.ObterTodos();
			return CustomResponse(menus.ToList());
		}


		[HttpGet]
		[Route("getbyid")]
		public async Task<ActionResult<Submenu>> GetByID(int id)
		{
			Submenu submenu = await _submenuRepository.ObterPorID(id);
			return CustomResponse(submenu);
		}

		[HttpPost]
		public async Task<IActionResult> Post([FromBody] SubmenuDTO submenu)
		{
			try
			{
				await _submenuRepository.Adicionar(_mapper.Map<Submenu>(submenu));
				return CustomResponse();
			}
			catch (Exception ex)
			{
				NotificarErro(ex.Message);
				return CustomResponse();
			}
		}

		[HttpPut]
		public async Task<IActionResult> Put([FromBody] SubmenuDTO submenu)
		{
			try
			{
				await _submenuRepository.Atualizar(_mapper.Map<Submenu>(submenu));
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
				return CustomResponse(_submenuRepository.Remover(id));
			}
			catch (Exception ex)
			{
				NotificarErro(ex.Message);
				return CustomResponse();
			}
		}
	}
}
