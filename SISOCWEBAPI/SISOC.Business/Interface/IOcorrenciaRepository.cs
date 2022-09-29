using SISOC.Business.Models;

namespace SISOC.Business.Interface
{
	public interface IOcorrenciaRepository : IRepository<Ocorrencia>
	{
		Task<List<Ocorrencia>> ObterTodos();
	}
}
