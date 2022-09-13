using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using SISOC.Business.Models;

namespace SISOC.Data.Context
{
	public class SisocDbContext : DbContext
	{
		public SisocDbContext(DbContextOptions<SisocDbContext> options) : base(options) { }
		public DbSet<Anexo> Anexos { get; set; }
		public DbSet<InteracaoOcorrencia> Interacaos { get; set; }
		public DbSet<Modulo> Modulos { get; set; }
		public DbSet<Ocorrencia> Ocorrencias { get; set; }
		public DbSet<Permissao> Permissaos { get; set; }
		public DbSet<Setor> Setors { get; set; }
		public DbSet<TipoOcorrencia> TipoOcorrencias { get; set; }
		public DbSet<TipoUsuario> TipoUsuarios { get; set; }
		public DbSet<Usuario> Usuarios { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			foreach (var property in modelBuilder
			  .Model
			  .GetEntityTypes()
			  .SelectMany(
				 e => e.GetProperties()
					.Where(p => p.ClrType == typeof(string))))
			{
				property.SetColumnType("nvarchar(255)");
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
			foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataHoraCadastro") != null))
			{
				if (entry.State == EntityState.Added)
				{
					entry.Property("DataHoraCadastro").CurrentValue = DateTime.Now;
				}

				if (entry.State == EntityState.Modified)
				{
					entry.Property("DataHoraCadastro").IsModified = false;
					entry.Property("DataHoraAlteracao").CurrentValue = DateTime.Now;
				}
			}

			return base.SaveChangesAsync(cancellationToken);
		}
	}
}
