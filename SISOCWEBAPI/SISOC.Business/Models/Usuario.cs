using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SISOC.Business.Models
{
	[Table("Usuario")]
	public partial class Usuario : Entity
	{
		[Key]
		public int UsuarioID { get; set; }
		public string Nome { get; set; }
		public string Email { get; set; }
		public string Senha { get; set; }
		public string RA_SIAPE { get; set; }
		public int? TipoUsuarioID { get; set; }
		public int? SetorID { get; set; }

		[ForeignKey(nameof(TipoUsuarioID))]
		[InverseProperty("Usuarios")]
		public virtual TipoUsuario TipoUsuarioNavigation { get; set; }

		[ForeignKey(nameof(SetorID))]
		[InverseProperty("Usuarios")]
		public virtual Setor SetorNavigation { get; set; }

		[InverseProperty(nameof(InteracaoOcorrencia.UsuarioNavigation))]
		public virtual ICollection<InteracaoOcorrencia> InteracaoOcorrencias { get; set; }

		[InverseProperty(nameof(Ocorrencia.UsuarioCadastroNavigation))]
		public virtual ICollection<Ocorrencia> OcorrenciasCadastro { get; set; }

		[InverseProperty(nameof(Ocorrencia.UsuarioAtribuidoNavigation))]
		public virtual ICollection<Ocorrencia> OcorrenciasAtribuido { get; set; }
		public override void SetId(int id)
		{
			UsuarioID = id;
		}
	}
}
