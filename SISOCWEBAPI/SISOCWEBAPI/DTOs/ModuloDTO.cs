using System.ComponentModel.DataAnnotations;

namespace SISOCWEBAPI.DTOs
{
	public class ModuloDTO
	{
		[Key]
		public int ModuloID { get; set; }
		public string Nome { get; set; }
		public string NavegarURL { get; set; }
		public bool Ativo { get; set; }
		public bool PossuiMenu { get; set; }
	}
}
