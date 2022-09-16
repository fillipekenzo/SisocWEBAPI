using System.ComponentModel.DataAnnotations;

namespace SISOCWEBAPI.DTOs
{
    public class InteracaoOcorrenciaDTO
    {
        [Key]
        public int InteracaoOcorrenciaID { get; set; }
        public string Assunto { get; set; }
        public string Descricao { get; set; }
        public int UsuarioID { get; set; }
        public int OcorrenciaID { get; set; }
    }
}
