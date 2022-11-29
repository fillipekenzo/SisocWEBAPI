using SISOC.Business.Models;

namespace SISOC.Business.Interface
{
	public interface IOcorrenciaRepository : IRepository<Ocorrencia>
	{
		Task<Ocorrencia> ObterPorID(int id);
		Task<List<Ocorrencia>> ObterTodos();
	}
}
