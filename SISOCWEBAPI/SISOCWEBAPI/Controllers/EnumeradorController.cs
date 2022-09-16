using CONCURSOMS.Business.Models.Enumerador;
using Microsoft.AspNetCore.Mvc;
using SISOC.Business.Interface;
using SISOC.Util.Extensions;
using SISOCWEBAPI.DTOs;
using System.Reflection;

namespace SISOCWEBAPI.Controllers
{
	[Route("sisocwebapi/v1/[controller]")]
	public class EnumeradorController : MainController
	{

		public EnumeradorController(INotificador notificador) : base(notificador)
		{

		}

		[HttpGet]
		public ActionResult GetEnumerador(string tipoEnumerador)
		{
			try
			{
				Type type = typeof(SISOCEnumerador).GetNestedType(tipoEnumerador, BindingFlags.Public);
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

				return CustomResponse(listEnvelope);
			}
			catch (Exception ex)
			{
				return CustomResponse(ex);
			}

		}
	}
}
