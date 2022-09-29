using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SISOC.Business.Models
{
	[Table("Ocorrencia")]
	public partial class Ocorrencia : Entity
	{
		[Key]
		public int OcorrenciaID { get; set; }
		public string Assunto { get; set; }
		public string Descricao { get; set; }
		public string UrgenciaENUM { get; set; }
		public string SituacaoENUM { get; set; }
		public string? Resolucao { get; set; }
		public int? UsuarioAtribuidoID { get; set; }
		public int UsuarioCadastroID { get; set; }
		public int TipoOcorrenciaID { get; set; }
		public int SetorID { get; set; }

		[ForeignKey(nameof(UsuarioAtribuidoID))]
		[InverseProperty("OcorrenciasAtribuido")]
		public virtual Usuario UsuarioAtribuidoNavigation { get; set; }

		[ForeignKey(nameof(UsuarioCadastroID))]
		[InverseProperty("OcorrenciasCadastro")]
		public virtual Usuario UsuarioCadastroNavigation { get; set; }

		[ForeignKey(nameof(TipoOcorrenciaID))]
		[InverseProperty("Ocorrencias")]
		public virtual TipoOcorrencia TipoOcorrenciaNavigation { get; set; }

		[ForeignKey(nameof(SetorID))]
		[InverseProperty("Ocorrencias")]
		public virtual Setor SetorNavigation { get; set; }

		[InverseProperty(nameof(InteracaoOcorrencia.OcorrenciaNavigation))]
		public virtual ICollection<InteracaoOcorrencia> InteracaoOcorrencias { get; set; }

		[InverseProperty(nameof(Anexo.OcorrenciaNavigation))]
		public virtual ICollection<Anexo> Anexos { get; set; }

		public override void SetId(int id)
		{
			OcorrenciaID = id;
		}
	}
}
