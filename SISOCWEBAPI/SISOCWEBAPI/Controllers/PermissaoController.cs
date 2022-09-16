using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SISOC.Business.Interface;
using SISOC.Business.Models;
using SISOCWEBAPI.DTOs;

namespace SISOCWEBAPI.Controllers
{
	[Route("sisocwebapi/v1/[controller]")]
	public class PermissaoController : MainController
	{
		private readonly IWebHostEnvironment _env;
		private readonly IPermissaoRepository _permissaoRepository;
		private readonly IMapper _mapper;
		public PermissaoController(INotificador notificador,
							IPermissaoRepository permissaoRepository,
							IMapper mapper,
							IWebHostEnvironment env) : base(notificador)
		{
			_env = env;
			_permissaoRepository = permissaoRepository;
			_mapper = mapper;
		}
		[HttpGet]
		public async Task<ActionResult<List<Permissao>>> Get()
		{
			var modulos = await _permissaoRepository.ObterTodos();
			return CustomResponse(modulos.ToList());
		}


		[HttpGet]
		[Route("getbyid")]
		public async Task<ActionResult<Permissao>> GetByID(int id)
		{
			Permissao permissao = await _permissaoRepository.ObterPorID(id);
			return CustomResponse(permissao);
		}

		[HttpPost]
		public async Task<IActionResult> Post([FromBody] PermissaoDTO permissaoDTO)
		{
			try
			{
				await _permissaoRepository.Adicionar(_mapper.Map<Permissao>(permissaoDTO));
				return CustomResponse();
			}
			catch (Exception ex)
			{
				NotificarErro(ex.Message);
				return CustomResponse();
			}
		}

		[HttpPut]
		public async Task<IActionResult> Put([FromBody] PermissaoDTO permissaoDTO)
		{
			try
			{
				await _permissaoRepository.Atualizar(_mapper.Map<Permissao>(permissaoDTO));
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
				return CustomResponse(_permissaoRepository.Remover(id));
			}
			catch (Exception ex)
			{
				NotificarErro(ex.Message);
				return CustomResponse();
			}
		}
	}
}
