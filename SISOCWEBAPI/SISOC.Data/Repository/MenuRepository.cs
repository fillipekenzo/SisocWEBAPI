using Microsoft.EntityFrameworkCore;
using SISOC.Business.Interface;
using SISOC.Business.Models;
using SISOC.Business.Models.Interface;
using SISOC.Data.Context;
using System.Linq.Expressions;

namespace SISOC.Data.Repository
{
	public class MenuRepository : Repository<Menu>, IMenuRepository
	{
		public MenuRepository(SisocDbContext db) : base(db)
		{

		}
		public override async Task<List<Menu>> ObterTodos()
		{
			try
			{
				return await Db.Menus.Include(i => i.Submenus).ToListAsync();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		
	}
}
