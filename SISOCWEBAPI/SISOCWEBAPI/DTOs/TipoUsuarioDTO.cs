using System.ComponentModel.DataAnnotations;

namespace SISOCWEBAPI.DTOs
{
	public class TipoUsuarioDTO
	{
		[Key]
		public int TipoUsuarioID { get; set; }
		public string Nome { get; set; }
		public string Descricao { get; set; }
	}
}
