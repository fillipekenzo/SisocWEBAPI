using SISOC.Business.Models;
using System.Linq.Expressions;

namespace SISOC.Business.Interface
{
	public interface IUsuarioRepository : IRepository<Usuario>
	{
		Task<IEnumerable<Usuario>> GetByEmail(string email);
		Task<List<Usuario>> ObterTodos();

	}
}
