using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SISOC.Business.Interface;
using SISOC.Business.Models;
using SISOCWEBAPI.DTOs;

namespace SISOCWEBAPI.Controllers
{
	[Route("sisocwebapi/v1/[controller]")]
	public class MenuController : MainController
	{
		private readonly IWebHostEnvironment _env;
		private readonly IMenuRepository _menuRepository;
		private readonly IPermissaoRepository _permissaoRepository;
		private readonly IMapper _mapper;
		public MenuController(INotificador notificador,
							IMenuRepository menuRepository,
							IPermissaoRepository permissaoRepository,
							IMapper mapper,
							IWebHostEnvironment env) : base(notificador)
		{
			_env = env;
			_menuRepository = menuRepository;
			_permissaoRepository = permissaoRepository;
			_mapper = mapper;
		}
		[HttpGet]
		public async Task<ActionResult<List<Menu>>> Get()
		{
			var menus = await _menuRepository.ObterTodos();
			foreach (var menu in menus)
			{
				menu.Submenus.OrderBy(sm => sm.Ordem);
			}
			return CustomResponse(menus.ToList().OrderBy(m => m.Ordem));
		}

		[HttpGet]
		[Route("getbytipousuarioid")]
		public async Task<ActionResult<Menu>> GetByTipoUsuarioID(int tipousuarioid)
		{
			var permissaos = await _permissaoRepository.ObterPorTipoUsuarioID(tipousuarioid);
			var menus = new List<MenuDTO>();
			foreach (var permissao in permissaos)
			{
				permissao.MenuNavigation.Submenus.OrderBy(sm => sm.Ordem);
				menus.Add(_mapper.Map<MenuDTO>(permissao.MenuNavigation));
			}

			return CustomResponse(menus.ToList().OrderBy(m => m.Ordem));
		}

		[HttpGet]
		[Route("getbyid")]
		public async Task<ActionResult<Menu>> GetByID(int id)
		{
			Menu menu = await _menuRepository.ObterPorID(id);
			return CustomResponse(menu);
		}

		[HttpPost]
		public async Task<IActionResult> Post([FromBody] MenuDTO menu)
		{
			try
			{
				await _menuRepository.Adicionar(_mapper.Map<Menu>(menu));
				return CustomResponse();
			}
			catch (Exception ex)
			{
				NotificarErro(ex.Message);
				return CustomResponse();
			}
		}

		[HttpPut]
		public async Task<IActionResult> Put([FromBody] MenuDTO menu)
		{
			try
			{
				await _menuRepository.Atualizar(_mapper.Map<Menu>(menu));
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
