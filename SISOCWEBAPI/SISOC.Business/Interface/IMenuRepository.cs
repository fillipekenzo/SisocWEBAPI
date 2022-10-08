using SISOC.Business.Models;

namespace SISOC.Business.Interface
{
	public interface IMenuRepository : IRepository<Menu>
	{
		Task<List<Menu>> ObterTodos();
	}
}
