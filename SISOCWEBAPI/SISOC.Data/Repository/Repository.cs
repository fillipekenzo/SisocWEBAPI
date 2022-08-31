using Microsoft.EntityFrameworkCore;
using SISOC.Business.Interface;
using SISOC.Business.Models;
using SISOC.Data.Context;
using System.Linq.Expressions;

namespace SISOC.Data.Repository
{
	public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity, new()
	{
		protected readonly SisocDbContext Db;
		protected readonly DbSet<TEntity> DbSet;

		protected Repository(SisocDbContext db)
		{
			Db = db;
			DbSet = db.Set<TEntity>();
		}

		public virtual async Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate = null)
		{
			try
			{
				return await DbSet.AsNoTracking().Where(predicate).ToListAsync();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public virtual async Task Adicionar(TEntity entity)
		{
			try
			{
				DbSet.Add(entity);
				await SaveChanges();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public virtual async Task Atualizar(TEntity entity)
		{
			try
			{
				DbSet.Update(entity);
				await SaveChanges();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public virtual async Task<TEntity> ObterPorID(int id)
		{
			try
			{
				return await DbSet.FindAsync(id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public virtual async Task<List<TEntity>> ObterTodos()
		{
			try
			{
				return await DbSet.ToListAsync();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public virtual async Task Remover(int id)
		{
			try
			{
				TEntity entity = new TEntity();
				entity.SetId(id);
				DbSet.Remove(entity);
				await SaveChanges();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public async Task<int> SaveChanges()
		{
			try
			{
				return await Db.SaveChangesAsync();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public virtual void Dispose()
		{
			try
			{
				Db?.Dispose();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

	}
}
