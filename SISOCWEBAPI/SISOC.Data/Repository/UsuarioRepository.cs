using Microsoft.EntityFrameworkCore;
using SISOC.Business.Interface;
using SISOC.Business.Models;
using SISOC.Business.Models.Interface;
using SISOC.Data.Context;
using System.Linq.Expressions;

namespace SISOC.Data.Repository
{
	public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
	{
		public UsuarioRepository(SisocDbContext db) : base(db)
		{

		}
		public virtual async Task<IEnumerable<Usuario>> GetByEmail(string email)
		{
			try
			{
				return await DbSet.AsNoTracking().Where(u => u.Email == email)
					.Include(u => u.TipoUsuarioNavigation).ThenInclude(t => t.Permissaos)
					.Include(u => u.SetorNavigation)
					.ToListAsync();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public override async Task<List<Usuario>> ObterTodos()
		{
			try
			{
				return await Db.Usuarios.Include(i => i.TipoUsuarioNavigation).Include(i => i.SetorNavigation).ToListAsync();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
