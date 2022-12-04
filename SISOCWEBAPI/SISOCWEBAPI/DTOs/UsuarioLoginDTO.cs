using System.ComponentModel.DataAnnotations;

namespace SISOCWEBAPI.DTOs
{
	public class UsuarioLoginDTO
	{
		[Required(ErrorMessage = "O campo E-mail é obrigatório")]
		[EmailAddress(ErrorMessage = "O campo E-mail esta em formato inválido")]
		public string Email { get; set; }

		[Required(ErrorMessage = "O campo senha é obrigatório")]
		[StringLength(20, ErrorMessage = "O campo senha precisa ter entre {2} e {1} caracteres", MinimumLength = 4)]
		public string Senha { get; set; }
	}
}
