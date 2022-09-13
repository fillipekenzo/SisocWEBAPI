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
		public int? InteracaoOcorrenciaID { get; set; }
		public int? OcorrenciaID { get; set; }

		[ForeignKey(nameof(InteracaoOcorrenciaID))]
		[InverseProperty("Anexos")]
		public virtual InteracaoOcorrencia InteracaoOcorrenciaNavigation { get; set; }

		[ForeignKey(nameof(OcorrenciaID))]
		[InverseProperty("Anexos")]
		public virtual Ocorrencia OcorrenciaNavigation { get; set; }
		public override void SetId(int id)
		{
			AnexoID = id;
		}
	}
}
