using AutoMapper;
using CONCURSOMS.Business.Models.Enumerador;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SISOC.Business.Interface;
using SISOC.Business.Models;
using SISOC.Util.Consulta.Filtros;
using SISOC.Util.Extensions;
using SISOC.Util.Mail;
using SISOCWEBAPI.DTOs;
using SISOCWEBAPI.ViewModels;
using System.Reflection;
using static CONCURSOMS.Business.Models.Enumerador.SISOCEnumerador;

namespace SISOCWEBAPI.Controllers
{
	[Route("sisocwebapi/v1/[controller]")]
	public class OcorrenciaController : MainController
	{
		private readonly IWebHostEnvironment _env;
		private readonly IOcorrenciaRepository _ocorrenciaRepository;
		private readonly IAnexoService _anexoService;
		private readonly IOcorrenciaService _ocorrenciaService;
		private readonly IMapper _mapper;
		
		public OcorrenciaController(INotificador notificador,
							IOcorrenciaRepository ocorrenciaRepository,
							IAnexoService anexoService,
							IOcorrenciaService ocorrenciaService,
							IMapper mapper,
							IWebHostEnvironment env) : base(notificador)
		{
			_env = env;
			_ocorrenciaRepository = ocorrenciaRepository;
			_anexoService = anexoService;
			_ocorrenciaService = ocorrenciaService;
			_mapper = mapper;
			
		}

		[HttpGet]
		public async Task<ActionResult<List<OcorrenciaViewModel>>> Get()
		{
			var ocorrencias = _mapper.Map<List<OcorrenciaViewModel>>(await _ocorrenciaRepository.ObterTodos());
			Type type = typeof(SISOCEnumerador).GetNestedType("ESituacaoOcorrencia", BindingFlags.Public);
			List<object> listaEnumeradores = EnumExtensions.ListaObjectEnum(type);
			List<EnumeradorDTO> listEnvelope = new List<EnumeradorDTO>();
			foreach (object enumerador in listaEnumeradores)
			{
				EnumeradorDTO instancia = new EnumeradorDTO();
				instancia.Valor = (Int32)enumerador.GetType().GetProperty("Valor").GetValue(enumerador);
				instancia.Enum = enumerador.GetType().GetProperty("Enum").GetValue(enumerador).ToString();
				instancia.Texto = enumerador.GetType().GetProperty("Texto").GetValue(enumerador).ToString();
				listEnvelope.Add(instancia);
			}

			foreach (var ocorrencia in ocorrencias)
			{
				ocorrencia.SituacaoTexto = listEnvelope.Where(e => e.Enum == ocorrencia.Situacao).FirstOrDefault().Texto;
			}
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
				foreach (var interacao in ocorrencia.InteracaoOcorrencias)
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
				await _ocorrenciaService.EnviarEmailAtendimentoSetor(ocorrencia);

				return CustomResponse();
			}
			catch (Exception ex)
			{
				NotificarErro(ex.Message);
				return CustomResponse();
			}
		}

		[HttpPost("postcomfiltros")]
		public async Task<ActionResult<List<Ocorrencia>>> PostComFiltros([FromBody] OcorrenciaFiltros ocorrenciaFiltros)
		{
			try
			{
				var ocorrencias = _mapper.Map<List<OcorrenciaViewModel>>(await _ocorrenciaService.BuscarComFiltro(ocorrenciaFiltros));
				return CustomResponse(ocorrencias);
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
