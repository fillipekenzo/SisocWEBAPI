using System.ComponentModel.DataAnnotations;

namespace SISOCWEBAPI.DTOs
{
	public class PermissaoDTO
	{
		[Key]
		public int PermissaoID { get; set; }
		public int ModuloID { get; set; }
		public int TipoUsuarioID { get; set; }
		public bool Consultar { get; set; }
		public bool Cadastrar { get; set; }
		public bool Editar { get; set; }
		public bool Excluir { get; set; }
	}
}
