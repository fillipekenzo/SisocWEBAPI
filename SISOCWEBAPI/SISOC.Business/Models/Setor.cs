using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SISOC.Business.Models
{
	[Table("Setor")]
	public partial class Setor : Entity
	{
		[Key]
		public int SetorID { get; set; }
		public string Nome { get; set; }
		public string Sigla { get; set; }

		[InverseProperty(nameof(Usuario.SetorNavigation))]
		public virtual ICollection<Usuario> Usuarios { get; set; }

		[InverseProperty(nameof(Ocorrencia.SetorNavigation))]
		public virtual ICollection<Ocorrencia> Ocorrencias { get; set; }
		public override void SetId(int id)
		{
			SetorID = id;

		}
	}
}