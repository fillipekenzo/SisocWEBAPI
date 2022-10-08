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
		private readonly ISubmenuRepository _menuRepository;
		private readonly IMapper _mapper;
		public SubmenuController(INotificador notificador,
							ISubmenuRepository menuRepository,
							IMapper mapper,
							IWebHostEnvironment env) : base(notificador)
		{
			_env = env;
			_menuRepository = menuRepository;
			_mapper = mapper;
		}
		[HttpGet]
		public async Task<ActionResult<List<Submenu>>> Get()
		{
			var menus = await _menuRepository.ObterTodos();
			return CustomResponse(menus.ToList());
		}


		[HttpGet]
		[Route("getbyid")]
		public async Task<ActionResult<Submenu>> GetByID(int id)
		{
			Submenu menu = await _menuRepository.ObterPorID(id);
			return CustomResponse(menu);
		}

		[HttpPost]
		public async Task<IActionResult> Post([FromBody] SubmenuDTO menu)
		{
			try
			{
				await _menuRepository.Adicionar(_mapper.Map<Submenu>(menu));
				return CustomResponse();
			}
			catch (Exception ex)
			{
				NotificarErro(ex.Message);
				return CustomResponse();
			}
		}

		[HttpPut]
		public async Task<IActionResult> Put([FromBody] SubmenuDTO menu)
		{
			try
			{
				await _menuRepository.Atualizar(_mapper.Map<Submenu>(menu));
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
				return CustomResponse(_menuRepository.Remover(id));
			}
			catch (Exception ex)
			{
				NotificarErro(ex.Message);
				return CustomResponse();
			}
		}
	}
}
