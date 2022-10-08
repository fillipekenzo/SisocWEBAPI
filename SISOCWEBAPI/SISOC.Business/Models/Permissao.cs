using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SISOC.Business.Models
{
	[Table("Permissao")]
	public partial class Permissao : Entity
	{
		[Key]
		public int PermissaoID { get; set; }
		public int TipoUsuarioID { get; set; }
		public bool Consultar { get; set; }
		public bool Cadastrar { get; set; }
		public bool Editar { get; set; }
		public bool Excluir { get; set; }
		public int? MenuID { get; set; }
		public int? SubmenuID { get; set; }

		[ForeignKey(nameof(MenuID))]
		[InverseProperty("Permissoes")]
		public virtual Menu MenuNavigation { get; set; }
		[ForeignKey(nameof(SubmenuID))]
		[InverseProperty("Permissoes")]
		public virtual Submenu SubmenuNavigation { get; set; }

		[ForeignKey(nameof(TipoUsuarioID))]
		[InverseProperty("Permissaos")]
		public virtual TipoUsuario TipoUsuarioNavigation { get; set; }
		public override void SetId(int id)
		{
			PermissaoID = id;
		}
	}
}
