using System.ComponentModel.DataAnnotations;

namespace SISOCWEBAPI.DTOs
{
	public class UsuarioRegistroDTO
	{

		[Required(ErrorMessage = "O campo {0} é obrigatório")]
		public string Nome { get; set; }

		[Required(ErrorMessage = "O campo E-mail é obrigatório")]
		[EmailAddress(ErrorMessage = "O campo E-mail esta em formato inválido")]
		public string Email { get; set; }
		public string RA_SIAPE { get; set; }

		[Required(ErrorMessage = "O campo senha é obrigatório")]
		[StringLength(20, ErrorMessage = "O campo senha precisa ter entre {2} e {1} caracteres", MinimumLength = 6)]
		public string Senha { get; set; }

		[Compare("Senha", ErrorMessage = "As senhas não são iguais")]
		public string SenhaConfirma { get; set; }

	}
}
