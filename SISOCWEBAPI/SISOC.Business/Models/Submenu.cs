using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SISOC.Business.Models
{
	[Table("Submenu")]
	public partial class Submenu : Entity
	{
		public Submenu()
		{
			Permissoes = new HashSet<Permissao>();
		}

		[Key]
		public int SubmenuID { get; set; }
		[Required]
		[StringLength(50)]
		public string Nome { get; set; }
		[Required]
		[StringLength(50)]
		public string NavegarURL { get; set; }
		public bool Ativo { get; set; }
		public int? Ordem { get; set; }
		public int MenuID { get; set; }

		[ForeignKey(nameof(MenuID))]
		[InverseProperty("Submenus")]
		public virtual Menu MenuNavigation { get; set; }

		[InverseProperty(nameof(Permissao.SubmenuNavigation))]
		public virtual ICollection<Permissao> Permissoes { get; set; }
		public override void SetId(int id)
		{
			SubmenuID = id;
		}
	}
}
