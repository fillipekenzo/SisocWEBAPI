using SISOC.Business.Models;
using System.ComponentModel.DataAnnotations;

namespace SISOCWEBAPI.ViewModels
{
	public class OcorrenciaViewModel
	{
		public int OcorrenciaID { get; set; }
		public string Assunto { get; set; }
		public string Descricao { get; set; }
		public string Urgencia { get; set; }
		public string Situacao { get; set; }
		public string Resolucao { get; set; }
		public DateTime DataHoraCadastro { get; set; }
		public int? UsuarioAtribuidoID { get; set; }
		public Usuario? UsuarioAtribuido { get; set; }
		public int UsuarioCadastroID { get; set; }
		public Usuario UsuarioCadastro { get; set; }
		public int TipoOcorrenciaID { get; set; }
		public TipoOcorrencia TipoOcorrencia { get; set; }
		public int SetorID { get; set; }
		public Setor Setor { get; set; }
		public ICollection<InteracaoOcorrencia> InteracaoOcorrencias { get; set; }
	}
}
