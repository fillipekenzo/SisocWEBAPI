using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace SISOCWEBAPI.Configurations
{
	public static class DependencyInjectionConfig
	{
		public static IServiceCollection ResolveDependecies(this IServiceCollection services)
		{
			return services;
		}
	}
}
