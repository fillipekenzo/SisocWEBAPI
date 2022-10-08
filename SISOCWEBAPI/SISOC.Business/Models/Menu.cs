using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SISOC.Business.Models
{
	[Table("Menu")]
	public partial class Menu : Entity
	{
		public Menu()
		{
			Permissoes = new HashSet<Permissao>();
			Submenus = new HashSet<Submenu>();
		}
		[Key]
		public int MenuID { get; set; }
		[Required]
		[StringLength(50)]
		public string Nome { get; set; }
		[Required]
		[StringLength(50)]
		public string NavegarURL { get; set; }
		public bool Ativo { get; set; }
		public int? Ordem { get; set; }

		[InverseProperty(nameof(Permissao.MenuNavigation))]
		public virtual ICollection<Permissao> Permissoes { get; set; }

		[InverseProperty(nameof(Submenu.MenuNavigation))]
		public virtual ICollection<Submenu> Submenus { get; set; }

		public override void SetId(int id)
		{
			MenuID = id;
		}
	}
}