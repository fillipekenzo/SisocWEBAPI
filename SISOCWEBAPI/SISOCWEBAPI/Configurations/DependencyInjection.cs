using SISOC.Business.Interface;
using SISOC.Business.Notificacoes;
using SISOC.Business.Service;
using SISOC.Data.Context;
using SISOC.Data.Repository;

namespace SISOCWEBAPI.Configurations
{
	public static class DependencyInjectionConfig
	{
		public static IServiceCollection ResolveDependecies(this IServiceCollection services)
		{
			services.AddScoped<SisocDbContext>();
			services.AddScoped<INotificador, Notificador>();

			// Repository
			services.AddScoped<IAnexoRepository, AnexoRepository>();
			services.AddScoped<IInteracaoOcorrenciaRepository, InteracaoOcorrenciaRepository>();
			services.AddScoped<IMenuRepository, MenuRepository>();
			services.AddScoped<IOcorrenciaRepository, OcorrenciaRepository>();
			services.AddScoped<IPermissaoRepository, PermissaoRepository>();
			services.AddScoped<ISetorRepository, SetorRepository>();
			services.AddScoped<ITipoOcorrenciaRepository, TipoOcorrenciaRepository>();
			services.AddScoped<ITipoUsuarioRepository, TipoUsuarioRepository>();
			services.AddScoped<IUsuarioRepository, UsuarioRepository>();
			services.AddScoped<ISubmenuRepository, SubmenuRepository>();

			// Service
			services.AddScoped<IUsuarioService, UsuarioService>();

			return services;
		}
	}
}
