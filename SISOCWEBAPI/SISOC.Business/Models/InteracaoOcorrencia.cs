using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SISOC.Business.Models
{
	[Table("InteracaoOcorrencia")]
	public partial class InteracaoOcorrencia : Entity
	{
		[Key]
		public int InteracaoOcorrenciaID { get; set; }
		public string Assunto { get; set; }
		public string Descricao { get; set; }
		public int UsuarioID { get; set; }
		public int OcorrenciaID { get; set; }

		[ForeignKey(nameof(UsuarioID))]
		[InverseProperty("InteracaoOcorrencias")]
		public virtual Usuario UsuarioNavigation { get; set; }

		[ForeignKey(nameof(OcorrenciaID))]
		[InverseProperty("InteracaoOcorrencias")]
		public virtual Ocorrencia OcorrenciaNavigation { get; set; }

		[InverseProperty(nameof(Anexo.InteracaoOcorrenciaNavigation))]
		public virtual ICollection<Anexo> Anexos { get; set; }

		public override void SetId(int id)
		{
			InteracaoOcorrenciaID = id;
		}
	}
}
