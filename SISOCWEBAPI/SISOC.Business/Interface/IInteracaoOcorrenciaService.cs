using SISOC.Business.Models;

namespace SISOC.Business.Interface
{
	public interface IInteracaoOcorrenciaService
	{
		Task<bool> Post(Ocorrencia ocorrencia);
		Task EnviarEmailAtendimentoSetorInteracaoOcorrencia(InteracaoOcorrencia interacaoOcorrencia);
	}
}
