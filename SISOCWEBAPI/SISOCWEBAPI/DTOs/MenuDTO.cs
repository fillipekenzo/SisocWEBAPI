using SISOC.Business.Models;
using System.ComponentModel.DataAnnotations;

namespace SISOCWEBAPI.DTOs
{
	public class MenuDTO
	{
		[Key]
		public int MenuID { get; set; }
		public string Nome { get; set; }
		public string NavegarURL { get; set; }
		public bool Ativo { get; set; }
		public bool PossuiMenu { get; set; }
        public int? Ordem { get; set; }
		public virtual ICollection<Submenu>? Submenus { get; set; }

	}
}
