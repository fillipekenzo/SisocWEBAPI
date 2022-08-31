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
			services.AddScoped<IUsuarioRepository, UsuarioRepository>();
			services.AddScoped<IUsuarioService, UsuarioService>();
			return services;
		}
	}
}
