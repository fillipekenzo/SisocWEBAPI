using SISOC.Business.Models;
using System.Linq.Expressions;

namespace SISOC.Business.Interface
{
	public interface IPermissaoRepository : IRepository<Permissao>
	{
		Task<List<Permissao>> ObterTodos();
		Task<IEnumerable<Permissao>> Buscar(Expression<Func<Permissao, bool>> predicate = null);
		Task<List<Permissao>> ObterPorTipoUsuarioID(int tipoUsuarioID);
	}
}
