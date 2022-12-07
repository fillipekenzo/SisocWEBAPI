using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using SISOC.Business.Models;
using SISOC.Util.Criptografia;

namespace SISOC.Data.Context
{
	public class SisocDbContext : DbContext
	{
		public SisocDbContext(DbContextOptions<SisocDbContext> options) : base(options) { }
		public DbSet<Anexo> Anexos { get; set; }
		public DbSet<InteracaoOcorrencia> Interacaos { get; set; }
		public DbSet<Menu> Menus { get; set; }
		public DbSet<Submenu> Submenus { get; set; }
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
			SeedSetor(modelBuilder);
			SeedTipoUsuario(modelBuilder);
			SeedTipoOcorrencia(modelBuilder);
			SeedMenuSubmenu(modelBuilder);
			SeedPermissao(modelBuilder);
			SeedUsuario(modelBuilder);
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

		private void SeedSetor(ModelBuilder builder)
		{
			builder.Entity<Setor>().HasData(
				new Setor() { SetorID = 1, Nome = "Conselho Superior", Sigla = "COSUP", DataHoraCadastro = DateTime.Now },
				new Setor() { SetorID = 2, Nome = "Reitoria", Sigla = "RTRIA", DataHoraCadastro = DateTime.Now },
				new Setor() { SetorID = 3, Nome = "Diretoria de Ensino", Sigla = "DIREN", DataHoraCadastro = DateTime.Now }
				);
		}

		private void SeedTipoUsuario(ModelBuilder builder)
		{
			builder.Entity<TipoUsuario>().HasData(
				new TipoUsuario() { TipoUsuarioID = 1, Nome = "ADMIN", Descricao = "Usuário Admnistrador", DataHoraCadastro = DateTime.Now },
				new TipoUsuario() { TipoUsuarioID = 2, Nome = "ESTUDANTE", Descricao = "Usuário Estudante", DataHoraCadastro = DateTime.Now },
				new TipoUsuario() { TipoUsuarioID = 3, Nome = "DOCENTE", Descricao = "Usuário Docente", DataHoraCadastro = DateTime.Now },
				new TipoUsuario() { TipoUsuarioID = 4, Nome = "ATENDIMENTO", Descricao = "Usuário responsável por atender as Ocorrências", DataHoraCadastro = DateTime.Now },
				new TipoUsuario() { TipoUsuarioID = 5, Nome = "SUPORTE", Descricao = "Usuário com permissões para criar usuários", DataHoraCadastro = DateTime.Now }
				);
		}

		private void SeedUsuario(ModelBuilder builder)
		{
			Usuario usuario = new Usuario()
			{
				UsuarioID = 1,
				Nome = "ADMIN",
				Email = "admin@email.com",
				Senha = Cripto.HashPassword("admin123"),
				SetorID = 1,
				RA_SIAPE = "123",
				TipoUsuarioID = 1,
			};
			builder.Entity<Usuario>().HasData(usuario);
		}

		private void SeedMenuSubmenu(ModelBuilder builder)
		{
			builder.Entity<Menu>().HasData(
				new Menu() { MenuID = 1, Nome = "Menu", NavegarURL = "/menu", Ativo = true, Ordem = 1, DataHoraCadastro = DateTime.Now },
				new Menu() { MenuID = 2, Nome = "Setor", NavegarURL = "/setor", Ativo = true, Ordem = 2, DataHoraCadastro = DateTime.Now },
				new Menu() { MenuID = 3, Nome = "Permissão", NavegarURL = "/permissao", Ativo = true, Ordem = 3, DataHoraCadastro = DateTime.Now },
				new Menu() { MenuID = 4, Nome = "Tipo Ocorrência", NavegarURL = "/tipo-ocorrencia", Ativo = true, Ordem = 4, DataHoraCadastro = DateTime.Now },
				new Menu() { MenuID = 5, Nome = "Tipo Usuário", NavegarURL = "/tipo-usuario", Ativo = true, Ordem = 5, DataHoraCadastro = DateTime.Now },
				new Menu() { MenuID = 6, Nome = "Usuário", NavegarURL = "/usuario", Ativo = true, Ordem = 6, DataHoraCadastro = DateTime.Now },
				new Menu() { MenuID = 7, Nome = "Ocorrência", NavegarURL = "/ocorrencia", Ativo = true, Ordem = 7, DataHoraCadastro = DateTime.Now }
				);

			builder.Entity<Submenu>().HasData(
				new Submenu() { SubmenuID = 1, MenuID = 7, Nome = "Cadastrar", NavegarURL = "/cadastrar", Ativo = true, Ordem = 1, DataHoraCadastro = DateTime.Now },
				new Submenu() { SubmenuID = 2, MenuID = 7, Nome = "Consultar", NavegarURL = "/consultar", Ativo = true, Ordem = 2, DataHoraCadastro = DateTime.Now }
				);
		}

		private void SeedPermissao(ModelBuilder builder)
		{
			builder.Entity<Permissao>().HasData(
				new Permissao() { PermissaoID = 1, MenuID = 1, SubmenuID = 1, Cadastrar = true, Consultar = true, Editar = true, Excluir = true, TipoUsuarioID = 1, DataHoraCadastro = DateTime.Now },
				new Permissao() { PermissaoID = 2, MenuID = 2, SubmenuID = 1, Cadastrar = true, Consultar = true, Editar = true, Excluir = true, TipoUsuarioID = 1, DataHoraCadastro = DateTime.Now },
				new Permissao() { PermissaoID = 3, MenuID = 3, SubmenuID = 1, Cadastrar = true, Consultar = true, Editar = true, Excluir = true, TipoUsuarioID = 1, DataHoraCadastro = DateTime.Now },
				new Permissao() { PermissaoID = 4, MenuID = 4, SubmenuID = 1, Cadastrar = true, Consultar = true, Editar = true, Excluir = true, TipoUsuarioID = 1, DataHoraCadastro = DateTime.Now },
				new Permissao() { PermissaoID = 5, MenuID = 5, SubmenuID = 1, Cadastrar = true, Consultar = true, Editar = true, Excluir = true, TipoUsuarioID = 1, DataHoraCadastro = DateTime.Now },
				new Permissao() { PermissaoID = 6, MenuID = 6, SubmenuID = 1, Cadastrar = true, Consultar = true, Editar = true, Excluir = true, TipoUsuarioID = 1, DataHoraCadastro = DateTime.Now },
				new Permissao() { PermissaoID = 7, MenuID = 7, SubmenuID = 1, Cadastrar = true, Consultar = true, Editar = true, Excluir = true, TipoUsuarioID = 1, DataHoraCadastro = DateTime.Now },

				new Permissao() { PermissaoID = 8, MenuID = 7, SubmenuID = 1, Cadastrar = true, Consultar = true, Editar = true, Excluir = false, TipoUsuarioID = 2, DataHoraCadastro = DateTime.Now },

				new Permissao() { PermissaoID = 9, MenuID = 7, SubmenuID = 1, Cadastrar = true, Consultar = true, Editar = true, Excluir = false, TipoUsuarioID = 3, DataHoraCadastro = DateTime.Now },

				new Permissao() { PermissaoID = 10, MenuID = 7, SubmenuID = 1, Cadastrar = true, Consultar = true, Editar = true, Excluir = false, TipoUsuarioID = 4, DataHoraCadastro = DateTime.Now },

				new Permissao() { PermissaoID = 11, MenuID = 6, SubmenuID = 1, Cadastrar = true, Consultar = true, Editar = true, Excluir = false, TipoUsuarioID = 5, DataHoraCadastro = DateTime.Now },
				new Permissao() { PermissaoID = 12, MenuID = 7, SubmenuID = 1, Cadastrar = true, Consultar = true, Editar = true, Excluir = false, TipoUsuarioID = 5, DataHoraCadastro = DateTime.Now }

				);
		}

		private void SeedTipoOcorrencia(ModelBuilder builder)
		{
			builder.Entity<TipoOcorrencia>().HasData(
				new TipoOcorrencia() { TipoOcorrenciaID = 1, Nome = "Aluno", Descricao = "Incidentes com Alunos", DataHoraCadastro = DateTime.Now },
				new TipoOcorrencia() { TipoOcorrenciaID = 2, Nome = "Campus", Descricao = "Incidentes com o Câmpus", DataHoraCadastro = DateTime.Now },
				new TipoOcorrencia() { TipoOcorrenciaID = 3, Nome = "Sala de Aula", Descricao = "Incidentes dentro da Sala de Aula", DataHoraCadastro = DateTime.Now },
				new TipoOcorrencia() { TipoOcorrenciaID = 4, Nome = "Docente", Descricao = "Incidentes com Docente", DataHoraCadastro = DateTime.Now }
				);
		}
	}
}
