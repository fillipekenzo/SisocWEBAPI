using SISOC.Business.Interface;
using SISOC.Business.Models;
using SISOC.Data.Context;

namespace SISOC.Data.Repository
{
	public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
	{
		public UsuarioRepository(SisocDbContext db) : base(db)
		{

		}
	}
}
