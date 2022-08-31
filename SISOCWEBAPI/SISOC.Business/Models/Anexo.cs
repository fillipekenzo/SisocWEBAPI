using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SISOC.Business.Models
{
	[Table("Anexo")]
	public partial class Anexo : Entity
	{
		[Key]
		public int AnexoID { get; set; }
		public string Nome { get; set; }
		public string TipoAnexo { get; set; }
		public string ArquivoURL { get; set; }
		public int? InteracaoID { get; set; }
		public int? OcorrenciaID { get; set; }

		[ForeignKey(nameof(InteracaoID))]
		[InverseProperty("Anexos")]
		public virtual Interacao InteracaoNavigation { get; set; }

		[ForeignKey(nameof(OcorrenciaID))]
		[InverseProperty("Anexos")]
		public virtual Ocorrencia OcorrenciaNavigation { get; set; }
		public override void SetId(int id)
		{
			AnexoID = id;
		}
	}
}
