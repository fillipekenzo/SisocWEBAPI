using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SISOC.Business.Interface;
using SISOC.Business.Models;
using SISOCWEBAPI.DTOs;

namespace SISOCWEBAPI.Controllers
{
	[Route("sisocwebapi/v1/[controller]")]
	public class TipoOcorrenciaController : MainController
	{
		private readonly IWebHostEnvironment _env;
		private readonly ITipoOcorrenciaRepository _tipoOcorrenciaRepository;
		private readonly IMapper _mapper;
		public TipoOcorrenciaController(INotificador notificador,
							ITipoOcorrenciaRepository tipoOcorrenciaRepository,
							IMapper mapper,
							IWebHostEnvironment env) : base(notificador)
		{
			_env = env;
			_tipoOcorrenciaRepository = tipoOcorrenciaRepository;
			_mapper = mapper;
		}
		[HttpGet]
		public async Task<ActionResult<List<TipoOcorrencia>>> Get()
		{
			var modulos = await _tipoOcorrenciaRepository.ObterTodos();
			return CustomResponse(modulos.ToList());
		}


		[HttpGet]
		[Route("getbyid")]
		public async Task<ActionResult<TipoOcorrencia>> GetByID(int id)
		{
			TipoOcorrencia tipoOcorrencia = await _tipoOcorrenciaRepository.ObterPorID(id);
			return CustomResponse(tipoOcorrencia);
		}

		[HttpPost]
		public async Task<IActionResult> Post([FromBody] TipoOcorrenciaDTO tipoOcorrenciaDTO)
		{
			try
			{
				await _tipoOcorrenciaRepository.Adicionar(_mapper.Map<TipoOcorrencia>(tipoOcorrenciaDTO));
				return CustomResponse();
			}
			catch (Exception ex)
			{
				NotificarErro(ex.Message);
				return CustomResponse();
			}
		}

		[HttpPut]
		public async Task<IActionResult> Put([FromBody] TipoOcorrenciaDTO tipoOcorrenciaDTO)
		{
			try
			{
				await _tipoOcorrenciaRepository.Atualizar(_mapper.Map<TipoOcorrencia>(tipoOcorrenciaDTO));
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
				return CustomResponse(_tipoOcorrenciaRepository.Remover(id));
			}
			catch (Exception ex)
			{
				NotificarErro(ex.Message);
				return CustomResponse();
			}
		}
	}
}
