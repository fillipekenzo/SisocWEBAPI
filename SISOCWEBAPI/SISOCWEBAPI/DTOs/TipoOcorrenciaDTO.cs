using System.ComponentModel.DataAnnotations;

namespace SISOCWEBAPI.DTOs
{
	public class TipoOcorrenciaDTO
	{
		[Key]
		public int TipoOcorrenciaID { get; set; }
		public string Nome { get; set; }
		public string Descricao { get; set; }
	}
}
