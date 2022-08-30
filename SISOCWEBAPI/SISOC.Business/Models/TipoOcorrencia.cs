using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SISOC.Business.Models
{

	[Table("TipoOcorrencia")]
	public partial class TipoOcorrencia : Entity
	{
		[Key]
		public int TipoOcorrenciaID { get; set; }
		public string Nome { get; set; }
		public string Descricao { get; set; }

		[InverseProperty(nameof(Ocorrencia.TipoOcorrenciaNavigation))]
		public virtual ICollection<Ocorrencia> Ocorrencias { get; set; }
		public override void SetId(int id)
		{
			TipoOcorrenciaID = id;
		}
	}
}
