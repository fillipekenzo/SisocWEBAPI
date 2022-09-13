using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SISOC.Business.Interface;
using SISOC.Business.Models;

namespace SISOCWEBAPI.Controllers
{
	[Route("sisocwebapi/v1/[controller]")]
	public class OcorrenciaController : MainController
	{
		private readonly IWebHostEnvironment _env;
		private readonly IOcorrenciaRepository _ocorrenciaRepository;
		private readonly IMapper _mapper;
		public OcorrenciaController(INotificador notificador,
							IOcorrenciaRepository ocorrenciaRepository,
							IMapper mapper,
							IWebHostEnvironment env) : base(notificador)
		{
			_env = env;
			_ocorrenciaRepository = ocorrenciaRepository;
			_mapper = mapper;
		}
		[HttpGet]
		public async Task<ActionResult<List<Ocorrencia>>> Get()
		{
			var modulos = await _ocorrenciaRepository.ObterTodos();
			return CustomResponse(modulos.ToList());
		}


		[HttpGet]
		[Route("getbyid")]
		public async Task<ActionResult<Ocorrencia>> GetByID(int id)
		{
			Ocorrencia ocorrencia = await _ocorrenciaRepository.ObterPorID(id);
			return CustomResponse(ocorrencia);
		}

		[HttpPost]
		public async Task<IActionResult> Post(Ocorrencia ocorrencia)
		{
			try
			{
				await _ocorrenciaRepository.Adicionar(_mapper.Map<Ocorrencia>(ocorrencia));
				return CustomResponse();
			}
			catch (Exception ex)
			{
				NotificarErro(ex.Message);
				return CustomResponse();
			}
		}

		[HttpPut]
		public async Task<IActionResult> Put(Ocorrencia ocorrencia)
		{
			try
			{
				await _ocorrenciaRepository.Atualizar(_mapper.Map<Ocorrencia>(ocorrencia));
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
				return CustomResponse(_ocorrenciaRepository.Remover(id));
			}
			catch (Exception ex)
			{
				NotificarErro(ex.Message);
				return CustomResponse();
			}
		}
	}
}
