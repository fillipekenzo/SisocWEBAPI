using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SISOC.Business.Models
{
	[Table("TipoUsuario")]
	public partial class TipoUsuario : Entity
	{
		[Key]
		public int TipoUsuarioID { get; set; }
		public string Nome { get; set; }
		public string Descricao { get; set; }

		[InverseProperty(nameof(Permissao.TipoUsuarioNavigation))]
		public virtual ICollection<Permissao> Permissaos { get; set; }

		[InverseProperty(nameof(Usuario.TipoUsuarioNavigation))]
		public virtual ICollection<Usuario> Usuarios { get; set; }

		public override void SetId(int id)
		{
			TipoUsuarioID = id;
		}
	}
}
