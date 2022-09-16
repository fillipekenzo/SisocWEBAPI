using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SISOC.Business.Interface;
using SISOC.Business.Models;
using SISOCWEBAPI.DTOs;

namespace SISOCWEBAPI.Controllers
{
	[Route("sisocwebapi/v1/[controller]")]
	public class InteracaoOcorrenciaController : MainController
	{
		private readonly IWebHostEnvironment _env;
		private readonly IInteracaoOcorrenciaRepository _interacaoOcorrenciaRepository;
		private readonly IMapper _mapper;
		public InteracaoOcorrenciaController(INotificador notificador,
							IInteracaoOcorrenciaRepository interacaoOcorrenciaRepository,
							IMapper mapper,
							IWebHostEnvironment env) : base(notificador)
		{
			_env = env;
			_interacaoOcorrenciaRepository = interacaoOcorrenciaRepository;
			_mapper = mapper;
		}
		[HttpGet]
		public async Task<ActionResult<List<InteracaoOcorrencia>>> Get()
		{
			var modulos = await _interacaoOcorrenciaRepository.ObterTodos();
			return CustomResponse(modulos.ToList());
		}


		[HttpGet]
		[Route("getbyid")]
		public async Task<ActionResult<InteracaoOcorrencia>> GetByID(int id)
		{
			InteracaoOcorrencia interacaoOcorrencia = await _interacaoOcorrenciaRepository.ObterPorID(id);
			return CustomResponse(interacaoOcorrencia);
		}

		[HttpPost]
		public async Task<IActionResult> Post([FromBody] InteracaoOcorrenciaDTO interacaoOcorrenciaDTO)
		{
			try
			{
				await _interacaoOcorrenciaRepository.Adicionar(_mapper.Map<InteracaoOcorrencia>(interacaoOcorrenciaDTO));
				return CustomResponse();
			}
			catch (Exception ex)
			{
				NotificarErro(ex.Message);
				return CustomResponse();
			}
		}

		[HttpPut]
		public async Task<IActionResult> Put([FromBody] InteracaoOcorrenciaDTO interacaoOcorrenciaDTO)
		{
			try
			{
				await _interacaoOcorrenciaRepository.Atualizar(_mapper.Map<InteracaoOcorrencia>(interacaoOcorrenciaDTO));
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
				return CustomResponse(_interacaoOcorrenciaRepository.Remover(id));
			}
			catch (Exception ex)
			{
				NotificarErro(ex.Message);
				return CustomResponse();
			}
		}
	}
}
