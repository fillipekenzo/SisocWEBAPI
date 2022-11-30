using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SISOC.Business.Interface;
using SISOC.Business.Models;
using SISOCWEBAPI.DTOs;
using SISOCWEBAPI.ViewModels;

namespace SISOCWEBAPI.Controllers
{
	[Route("sisocwebapi/v1/[controller]")]
	public class OcorrenciaController : MainController
	{
		private readonly IWebHostEnvironment _env;
		private readonly IOcorrenciaRepository _ocorrenciaRepository;
		private readonly IAnexoService _anexoService;
		private readonly IMapper _mapper;
		public OcorrenciaController(INotificador notificador,
							IOcorrenciaRepository ocorrenciaRepository,
							IAnexoService anexoService,
							IMapper mapper,
							IWebHostEnvironment env) : base(notificador)
		{
			_env = env;
			_ocorrenciaRepository = ocorrenciaRepository;
			_anexoService = anexoService;
			_mapper = mapper;
		}

		[HttpGet]
		public async Task<ActionResult<List<OcorrenciaViewModel>>> Get()
		{
			var ocorrencias = _mapper.Map<List<OcorrenciaViewModel>>(await _ocorrenciaRepository.ObterTodos());
			return CustomResponse(ocorrencias);
		}

		[HttpGet]
		[Route("getbyid")]
		public async Task<ActionResult<Ocorrencia>> GetByID(int id)
		{
			Ocorrencia ocorrencia = await _ocorrenciaRepository.ObterPorID(id);
			if (ocorrencia.Anexos.Any())
			{
				var anexo = await _anexoService.GetImagem(ocorrencia.Anexos.FirstOrDefault().AnexoID);
				ocorrencia.Anexos.Clear();
				ocorrencia.Anexos.Add(anexo);
			}
			if (ocorrencia.InteracaoOcorrencias.Any())
			{
				foreach(var interacao in ocorrencia.InteracaoOcorrencias)
				{
					if (interacao.Anexos.Any())
					{
						var anexo = await _anexoService.GetImagem(interacao.Anexos.FirstOrDefault().AnexoID);
						interacao.Anexos.Clear();
						interacao.Anexos.Add(anexo);
					}					
				}
			}
			
			return CustomResponse(ocorrencia);
		}


		[HttpPost]
		public async Task<IActionResult> Post(OcorrenciaDTO ocorrenciaDTO)
		{
			try
			{
				var ocorrencia = _mapper.Map<Ocorrencia>(ocorrenciaDTO);
				var ocorrenciaReturn = await _ocorrenciaRepository.Adicionar(_mapper.Map<Ocorrencia>(ocorrenciaDTO));
				if (ocorrenciaDTO.File != null)
				{
					var anexo = new Anexo()
					{
						OcorrenciaID = ocorrenciaReturn.OcorrenciaID,
					};
					await _anexoService.UploadImagem(anexo, ocorrenciaDTO.File);
				}
				return CustomResponse();
			}
			catch (Exception ex)
			{
				NotificarErro(ex.Message);
				return CustomResponse();
			}
		}

		[HttpPut]
		public async Task<IActionResult> Put([FromBody] OcorrenciaDTO ocorrenciaDTO)
		{
			try
			{
				await _ocorrenciaRepository.Atualizar(_mapper.Map<Ocorrencia>(ocorrenciaDTO));
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
