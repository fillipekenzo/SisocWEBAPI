using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace SISOCWEBAPI.Configurations
{
	public static class SwaggerConfig
	{
		public static IServiceCollection AddSwaggerConfig(this IServiceCollection services)
		{
			services.AddSwaggerGen(c =>
			{
				c.OperationFilter<SwaggerDefaultValues>();
				c.SwaggerDoc("v1", new OpenApiInfo
				{
					Title = "SISOCAPI",
					Version = "v1",
					Description = "API para gerenciar aplicação SISOC - Trabalho de Conclusão de Curso - Aluno: Fillipe Kenzo",
					Contact = new OpenApiContact
					{
						Name = "IFMS",
						Url = new Uri("https://www.ifms.edu.br/")
					}
				});

				c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
				{
					Description = "Autorization JWT no Header usando esquema Bearer. Insira apenas o Token no campo abaixo.",
					Name = "Authorization",
					BearerFormat = "JWT",
					In = ParameterLocation.Header,

					Type = SecuritySchemeType.Http,
					Scheme = "Bearer"
				});

				c.AddSecurityRequirement(new OpenApiSecurityRequirement
			{
				{
					new OpenApiSecurityScheme
					{
						Reference = new OpenApiReference
						{
							Type = ReferenceType.SecurityScheme,
							Id = "Bearer"
						}
					}, new string[] {}
				}
			});
			});

			return services;
		}
		public static IApplicationBuilder UseSwaggerConfig(this IApplicationBuilder app, IWebHostEnvironment env)
		{
			//app.UseMiddleware<SwaggerAuthorizedMiddleware>();           

			app.UseSwagger(c =>
			{
				c.RouteTemplate = "sisocwebapi/v1/swagger/{documentName}/swagger.json";
				c.PreSerializeFilters.Add((swagger, httpReq) =>
				{
					swagger.Servers = new List<OpenApiServer> { new OpenApiServer { Url = $"{httpReq.Scheme}://{httpReq.Host.Value}" } };
				});
			});
			app.UseSwaggerUI(c =>
			{
				c.SwaggerEndpoint("/sisocwebapi/v1/swagger/v1/swagger.json", "`Sisoc - API");
				c.RoutePrefix = "sisocwebapi/v1/swagger";
			});

			return app;
		}
	}

	public class SwaggerDefaultValues : IOperationFilter
	{
		public void Apply(OpenApiOperation operation, OperationFilterContext context)
		{
			if (operation.Parameters == null)
			{
				return;
			}


			foreach (var parameter in operation.Parameters)
			{
				var description = context.ApiDescription
					.ParameterDescriptions
					.First(p => p.Name == parameter.Name);

				var routeInfo = description.RouteInfo;

				operation.Deprecated = OpenApiOperation.DeprecatedDefault;

				if (parameter.Description == null)
				{
					parameter.Description = description.ModelMetadata?.Description;
				}

				if (routeInfo == null)
				{
					continue;
				}

				if (parameter.In != ParameterLocation.Path && parameter.Schema.Default == null)
				{
					parameter.Schema.Default = new OpenApiString(routeInfo.DefaultValue.ToString());
				}

				parameter.Required |= !routeInfo.IsOptional;
			}
		}
	}

	public class SwaggerAuthorizedMiddleware
	{
		private readonly RequestDelegate _next;

		public SwaggerAuthorizedMiddleware(RequestDelegate next)
		{
			_next = next;
		}

		public async Task Invoke(HttpContext context)
		{
			if (context.Request.Path.StartsWithSegments("/swagger")
				&& !context.User.Identity.IsAuthenticated)
			{
				context.Response.StatusCode = StatusCodes.Status401Unauthorized;
				return;
			}

			await _next.Invoke(context);
		}
	}
}
