using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;

namespace SISOC.Data.Data
{
	public class SisocDbContext : DbContext
	{
		public SisocDbContext(DbContextOptions<SisocDbContext> options) : base(options) { }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			foreach (var property in modelBuilder
			  .Model
			  .GetEntityTypes()
			  .SelectMany(
				 e => e.GetProperties()
					.Where(p => p.ClrType == typeof(string))))
			{
				property.SetColumnType("varchar(100)");
			}

			modelBuilder.ApplyConfigurationsFromAssembly(typeof(SisocDbContext).Assembly);

			foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys())) relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

			base.OnModelCreating(modelBuilder);
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.EnableSensitiveDataLogging();
		}

		public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
		{
			foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
			{
				if (entry.State == EntityState.Added)
				{
					entry.Property("DataCadastro").CurrentValue = DateTime.Now;
				}

				if (entry.State == EntityState.Modified)
				{
					entry.Property("DataCadastro").IsModified = false;
				}
			}

			return base.SaveChangesAsync(cancellationToken);
		}
	}
}
