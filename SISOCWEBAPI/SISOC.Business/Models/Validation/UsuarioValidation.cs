using FluentValidation;

namespace SISOC.Business.Models.Validation
{
	public class UsuarioValidation : AbstractValidator<Usuario>
	{
		public UsuarioValidation()
		{
			RuleFor(p => p.Nome)
				.NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
				.Length(2, 100).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");
			RuleFor(p => p.Email)
				.NotEmpty().WithMessage("O campo E-mail precisa ser fornecido")
				.Length(6, 100).WithMessage("O campo E-mail precisa ter entre {MinLength} e {MaxLength} caracteres");
			RuleFor(p => p.Senha)
				.NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
				.Length(6, 100).WithMessage("O campo{PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");
		}
	}
}
