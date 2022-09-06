using SISOC.Business.Models;

namespace SISOC.Business.Interface
{
	public interface IUsuarioRepository : IRepository<Usuario>
	{
		Task<IEnumerable<Usuario>> GetByEmail(string email);
	}
}
