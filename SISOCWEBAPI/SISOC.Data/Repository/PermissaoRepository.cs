using Microsoft.EntityFrameworkCore;
using SISOC.Business.Interface;
using SISOC.Business.Models;
using SISOC.Business.Models.Interface;
using SISOC.Data.Context;
using System.Linq.Expressions;

namespace SISOC.Data.Repository
{
	public class PermissaoRepository : Repository<Permissao>, IPermissaoRepository
	{
		public PermissaoRepository(SisocDbContext db) : base(db)
		{

		}

		public override async Task<List<Permissao>> ObterTodos()
		{
			try
			{
				return await Db.Permissaos.Include(i => i.TipoUsuarioNavigation).ToListAsync();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public override async Task<IEnumerable<Permissao>> Buscar(Expression<Func<Permissao, bool>> predicate = null)
		{
			try
			{
				return await Db.Permissaos.AsNoTracking().Include(i => i.TipoUsuarioNavigation).Where(predicate).ToListAsync();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public async Task<List<Permissao>> ObterPorTipoUsuarioID(int tipoUsuarioID)
		{
			try
			{
				return await Db.Permissaos.Where(t => t.TipoUsuarioID == tipoUsuarioID && t.Consultar && t.Cadastrar).Include(p => p.MenuNavigation).ThenInclude(i => i.Submenus).ToListAsync();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

	}
}
