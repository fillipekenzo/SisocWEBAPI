using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SISOC.Business.Interface;
using SISOC.Business.Models;

namespace SISOCWEBAPI.Controllers
{
	[Route("sisocwebapi/v1/[controller]")]
	public class TipoUsuarioController : MainController
	{
		private readonly IWebHostEnvironment _env;
		private readonly ITipoUsuarioRepository _tipoUsuarioRepository;
		private readonly IMapper _mapper;
		public TipoUsuarioController(INotificador notificador,
							ITipoUsuarioRepository tipoUsuarioRepository,
							IMapper mapper,
							IWebHostEnvironment env) : base(notificador)
		{
			_env = env;
			_tipoUsuarioRepository = tipoUsuarioRepository;
			_mapper = mapper;
		}
		[HttpGet]
		public async Task<ActionResult<List<TipoUsuario>>> Get()
		{
			var modulos = await _tipoUsuarioRepository.ObterTodos();
			return CustomResponse(modulos.ToList());
		}


		[HttpGet]
		[Route("getbyid")]
		public async Task<ActionResult<TipoUsuario>> GetByID(int id)
		{
			TipoUsuario tipoUsuario = await _tipoUsuarioRepository.ObterPorID(id);
			return CustomResponse(tipoUsuario);
		}

		[HttpPost]
		public async Task<IActionResult> Post(TipoUsuario tipoUsuario)
		{
			try
			{
				await _tipoUsuarioRepository.Adicionar(_mapper.Map<TipoUsuario>(tipoUsuario));
				return CustomResponse();
			}
			catch (Exception ex)
			{
				NotificarErro(ex.Message);
				return CustomResponse();
			}
		}

		[HttpPut]
		public async Task<IActionResult> Put(TipoUsuario tipoUsuario)
		{
			try
			{
				await _tipoUsuarioRepository.Atualizar(_mapper.Map<TipoUsuario>(tipoUsuario));
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
				return CustomResponse(_tipoUsuarioRepository.Remover(id));
			}
			catch (Exception ex)
			{
				NotificarErro(ex.Message);
				return CustomResponse();
			}
		}
	}
}
