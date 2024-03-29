﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SISOC.Business.Interface;
using SISOC.Business.Models;
using SISOC.Business.Service;
using SISOC.Data.Repository;
using SISOCWEBAPI.DTOs;

namespace SISOCWEBAPI.Controllers
{
	[Route("sisocwebapi/v1/[controller]")]
	public class InteracaoOcorrenciaController : MainController
	{
		private readonly IWebHostEnvironment _env;
		private readonly IInteracaoOcorrenciaRepository _interacaoOcorrenciaRepository;
		private readonly IAnexoService _anexoService;
		private readonly IInteracaoOcorrenciaService _interacaoOcorrenciaService;
		private readonly IMapper _mapper;
		public InteracaoOcorrenciaController(INotificador notificador,
							IInteracaoOcorrenciaRepository interacaoOcorrenciaRepository,
							IAnexoService anexoService,
							IInteracaoOcorrenciaService interacaoOcorrenciaService,
							IMapper mapper,
							IWebHostEnvironment env) : base(notificador)
		{
			_env = env;
			_interacaoOcorrenciaRepository = interacaoOcorrenciaRepository;
			_anexoService = anexoService;
			_interacaoOcorrenciaService = interacaoOcorrenciaService;
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
		public async Task<IActionResult> Post(InteracaoOcorrenciaDTO interacaoOcorrenciaDTO)
		{
			try
			{
				var ocorrencia = _mapper.Map<InteracaoOcorrencia>(interacaoOcorrenciaDTO);
				var ocorrenciaReturn = await _interacaoOcorrenciaRepository.Adicionar(_mapper.Map<InteracaoOcorrencia>(interacaoOcorrenciaDTO));
				if (interacaoOcorrenciaDTO.File != null)
				{
					var anexo = new Anexo()
					{
						InteracaoOcorrenciaID = ocorrenciaReturn.InteracaoOcorrenciaID,
					};
					await _anexoService.UploadImagem(anexo, interacaoOcorrenciaDTO.File);
				}

				await _interacaoOcorrenciaService.EnviarEmailAtendimentoSetorInteracaoOcorrencia(ocorrenciaReturn);
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
