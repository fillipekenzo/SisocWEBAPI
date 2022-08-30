using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SISOC.Business.Models
{
	[Table("Modulo")]
	public partial class Modulo : Entity
	{
		[Key]
		public int ModuloID { get; set; }
		public string Nome { get; set; }
		public string NavegarURL { get; set; }
		public bool Ativo { get; set; }
		public bool PossuiMenu { get; set; }

		[InverseProperty(nameof(Permissao.ModuloNavigation))]
		public virtual ICollection<Permissao> Permissaos { get; set; }

		public override void SetId(int id)
		{
			ModuloID = id;
		}
	}
}