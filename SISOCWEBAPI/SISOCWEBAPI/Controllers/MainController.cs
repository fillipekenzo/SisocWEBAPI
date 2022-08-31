using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using SISOC.Business.Interface;
using SISOC.Business.Notificacoes;

namespace SISOCWEBAPI.Controllers
{
	public abstract class MainController : ControllerBase
	{
		private readonly INotificador _notificador;
		public MainController(INotificador notificador)
		{
			_notificador = notificador;
		}

		protected bool OperacaoValida()
		{
			return !_notificador.TemNotificacao();
		}

		protected ActionResult CustomResponse(object result = null)
		{
			if (OperacaoValida())
			{
				return Ok(new
				{
					success = true,
					data = result
				}
					);
			}
			else
			{
				return BadRequest(new
				{
					success = false,
					error = _notificador.ObterNotificacoes().Select(n => n.mensagem)
				}
					); ;

			}

		}
		protected ActionResult CustomResponse(ModelStateDictionary modelState)
		{
			if (!modelState.IsValid)
			{
				NotificarErroModelInvalida(modelState);
			}
			return CustomResponse();
		}

		protected void NotificarErro(string erro)
		{
			_notificador.Handle(new Notificacao(erro));
		}
		protected void NotificarErroModelInvalida(ModelStateDictionary modelState)
		{
			var errors = modelState.Values.SelectMany(e => e.Errors);

			foreach (var erro in errors)
			{
				var errorMsg = erro.Exception == null ? erro.ErrorMessage : erro.Exception.Message;
				NotificarErro(errorMsg);
			}
		}
	}
}
