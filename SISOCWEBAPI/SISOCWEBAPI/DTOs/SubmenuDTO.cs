using System.ComponentModel.DataAnnotations;

namespace SISOCWEBAPI.DTOs
{
	public class SubmenuDTO
	{
		[Key]
		public int SubmenuID { get; set; }
		public string Nome { get; set; }
		public string NavegarURL { get; set; }
		public bool Ativo { get; set; }
		public int? Ordem { get; set; }
		public int MenuID { get; set; }
	}
}
