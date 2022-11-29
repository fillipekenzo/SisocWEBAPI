using SISOC.Business.Models;

namespace SISOC.Business.Interface
{
	public interface IOcorrenciaService
	{
		Task<bool> Post(Ocorrencia ocorrencia);
	}
}
