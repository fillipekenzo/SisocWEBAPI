using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SISOC.Business.Models
{
	[Table("Permissao")]
	public partial class Permissao : Entity
	{
		[Key]
		public int PermissaoID { get; set; }
		public int ModuloID { get; set; }
		public int TipoUsuarioID { get; set; }
		public bool Consultar { get; set; }
		public bool Cadastrar { get; set; }
		public bool Editar { get; set; }
		public bool Excluir { get; set; }

		[ForeignKey(nameof(ModuloID))]
		[InverseProperty("Permissaos")]
		public virtual Modulo ModuloNavigation { get; set; }

		[ForeignKey(nameof(TipoUsuarioID))]
		[InverseProperty("Permissaos")]
		public virtual TipoUsuario TipoUsuarioNavigation { get; set; }
		public override void SetId(int id)
		{
			PermissaoID = id;
		}
	}
}
