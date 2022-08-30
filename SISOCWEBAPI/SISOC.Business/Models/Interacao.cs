using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SISOC.Business.Models
{
	[Table("Interacao")]
	public partial class Interacao : Entity
	{
		[Key]
		public int InteracaoID { get; set; }
		public string Assunto { get; set; }
		public string Descricao { get; set; }
		public int UsuarioID { get; set; }
		public int OcorrenciaID { get; set; }

		[ForeignKey(nameof(UsuarioID))]
		[InverseProperty("Interacaos")]
		public virtual Usuario UsuarioNavigation { get; set; }

		[ForeignKey(nameof(OcorrenciaID))]
		[InverseProperty("Interacaos")]
		public virtual Ocorrencia OcorrenciaNavigation { get; set; }

		[InverseProperty(nameof(Anexo.InteracaoNavigation))]
		public virtual ICollection<Anexo> Anexos { get; set; }

		public override void SetId(int id)
		{
			InteracaoID = id;
		}
	}
}
