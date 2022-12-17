using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.WebEncoders.Testing;
using SISOC.Business.Interface;
using SISOC.Business.Models;
using SISOCWEBAPI.DTOs;
using SISOCWEBAPI.ViewModels;
using static CONCURSOMS.Business.Models.Enumerador.SISOCEnumerador;

namespace SISOCWEBAPI.Controllers
{
	[Route("sisocwebapi/v1/[controller]")]
	public class GraficoController : MainController
	{
		private readonly IWebHostEnvironment _env;
		private readonly IOcorrenciaRepository _ocorrenciaRepository;
		private readonly IMapper _mapper;
		public GraficoController(INotificador notificador,
							IOcorrenciaRepository ocorrenciaRepository,
							IMapper mapper,
							IWebHostEnvironment env) : base(notificador)
		{
			_env = env;
			_ocorrenciaRepository = ocorrenciaRepository;
			_mapper = mapper;
		}
		[HttpGet("getDadosGraficoVertical")]
		public async Task<ActionResult<List<GraficoViewModel>>> GetDadosGraficoVertical()
		{
			var graficoResponse = new GraficoViewModel();
			List<string> meses = new List<string>();
			List<int> quantidadeAberto = new List<int>();
			List<int> quantidadeResolvido = new List<int>();

			for (int i = 5; i >= 0 ; i--) {
				var mes = DateTime.Now.AddMonths(i * -1);
				meses.Add(mes.ToString("MMMM"));
				var dateInicio = new DateTime(mes.Year, mes.Month, 1);
				var dateFim = new DateTime(mes.Year, mes.Month, 30);
				var ocorrenciasAbertas = _ocorrenciaRepository.Buscar(o => o.DataHoraCadastro > new DateTime(mes.Year, mes.Month, 1) && o.DataHoraCadastro < new DateTime(mes.Year, mes.Month, 30));
				quantidadeAberto.Add(ocorrenciasAbertas.Result.Count());
			}

			for (int i = 5; i >= 0; i--)
			{
				var mes = DateTime.Now.AddMonths(i * -1);
				var dateInicio = new DateTime(mes.Year, mes.Month, 1);
				var dateFim = new DateTime(mes.Year, mes.Month, 30);
				var ocorrenciasResolvidas = _ocorrenciaRepository.Buscar(o => o.SituacaoENUM == ESituacaoOcorrencia.Resolvido.ToString() && o.DataHoraAlteracao > new DateTime(mes.Year, mes.Month, 1) && o.DataHoraAlteracao < new DateTime(mes.Year, mes.Month, 30));
				quantidadeResolvido.Add(ocorrenciasResolvidas.Result.Count());
			}

			graficoResponse.Meses = meses.ToArray();
			graficoResponse.QuantidadeResolvido = quantidadeResolvido.ToArray();
			graficoResponse.QuantidadeAberto = quantidadeAberto.ToArray() ;
			
			return CustomResponse(graficoResponse);
		}
	}
}
