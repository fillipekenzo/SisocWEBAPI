using System.ComponentModel.DataAnnotations;

namespace SISOCWEBAPI.DTOs
{
	public class UsuarioDTO
	{
		public string Nome { get; set; }
		public string Email { get; set; }
		public string Senha { get; set; }
		public string RA_SIAPE { get; set; }
	}
}
