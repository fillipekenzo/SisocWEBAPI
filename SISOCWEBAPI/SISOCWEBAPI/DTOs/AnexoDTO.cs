using System.ComponentModel.DataAnnotations;

namespace SISOCWEBAPI.DTOs
{
	public class AnexoDTO
	{
		[Key]
		public int AnexoID { get; set; }
		public string Nome { get; set; }
		public string TipoAnexo { get; set; }
		public string ArquivoURL { get; set; }
		public int? InteracaoOcorrenciaID { get; set; }
		public int? OcorrenciaID { get; set; }
	}
}
