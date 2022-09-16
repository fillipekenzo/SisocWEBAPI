using System.ComponentModel.DataAnnotations;

namespace SISOCWEBAPI.DTOs
{
	public class OcorrenciaDTO
	{
		[Key]
		public int OcorrenciaID { get; set; }
		public string Assunto { get; set; }
		public string Descricao { get; set; }
		public string UrgenciaENUM { get; set; }
		public string SituacaoENUM { get; set; }
		public string Resolucao { get; set; }
		public int? UsuarioAtribuidoID { get; set; }
		public int UsuarioCadastroID { get; set; }
		public int TipoOcorrenciaID { get; set; }
		public int SetorID { get; set; }
	}
}
