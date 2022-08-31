using SISOC.Business.Models;
using System.Linq.Expressions;

namespace SISOC.Business.Interface
{
	public interface IRepository<TEntity> : IDisposable where TEntity : Entity
	{
		Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate = null);
		Task<List<TEntity>> ObterTodos();
		Task<TEntity> ObterPorID(int id);
		Task Adicionar(TEntity entity);
		Task Atualizar(TEntity entity);
		Task Remover(int id);
		Task<int> SaveChanges();

	}
}
