using FluentValidation;
using FluentValidation.Results;
using SISOC.Business.Interface;
using SISOC.Business.Models;
using SISOC.Business.Notificacoes;

namespace SISOC.Business.Service
{
	public abstract class BaseService
	{
		private readonly INotificador _notificador;
		public BaseService(INotificador notificador)
		{
			_notificador = notificador;
			notificador.TemNotificacao();
		}

		public void Notificar(string mensagem)
		{
			_notificador.Handle(new Notificacao(mensagem));

		}

		public void Notificar(ValidationResult validationResult)
		{
			foreach (var error in validationResult.Errors)
			{
				Notificar(error.ErrorMessage);
			}
		}
		protected bool ExecutarValidacao<TV, TE>(TV validacao, TE entidade) where TV : AbstractValidator<TE> where TE : Entity
		{
			var validator = validacao.Validate(entidade);

			if (validator.IsValid) return true;

			Notificar(validator);

			return false;
		}

	}
}
