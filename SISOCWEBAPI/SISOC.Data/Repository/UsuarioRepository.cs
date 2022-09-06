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
					.ToListAsync();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
