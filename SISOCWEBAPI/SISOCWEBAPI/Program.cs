using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using SISOC.Data.Context;
using SISOC.Util.Configuration;
using SISOCWEBAPI.Configurations;
using SISOCWEBAPI.Extensions;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

var tokenConfigurations = new TokenConfiguration();
new ConfigureFromConfigurationOptions<TokenConfiguration>(
				builder.Configuration.GetSection("TokenConfigurations"))
.Configure(tokenConfigurations);

var signingConfigurations = new SigningConfiguration();

// Add services to the container (ConfigureServices).
builder.Configuration
	.SetBasePath(builder.Environment.ContentRootPath)
	.AddJsonFile("appsettings.json", true, true)
	.AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", true, true)
	.AddEnvironmentVariables();


builder.Services.AddAutoMapper(typeof(Program).Assembly);

builder.Services.AddDbContext<SisocDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers().AddNewtonsoftJson(op => op.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerConfig();

builder.Services.AddMvc(option => option.EnableEndpointRouting = false)
			  .AddNewtonsoftJson(opt =>
			  {
				  opt.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
				  opt.SerializerSettings.ContractResolver = new DefaultContractResolver();
			  });

builder.Services.AddCors(options =>
{
	// CORS de exemplo para desenvolvimento
	options.AddPolicy("Development", builder => builder
		.AllowAnyOrigin()
		.AllowAnyMethod()
		.AllowAnyHeader()
		.SetIsOriginAllowed(origin => true) // fix para ASpNet Core 3.1 , desabilitar 'AllowCredentials()' 
											//.AllowCredentials()
	);

	// CORS de exemplo para produção
	// editar conforme necessidade
	options.AddPolicy("Production", builder => builder
	   .WithMethods("GET")
	   .WithOrigins("http://desenvolvedor.io") // somente este site consegue fazer GET na api
	   .SetIsOriginAllowedToAllowWildcardSubdomains() // permite outras aplicações sob o mesmo domínio
													  //.WithHeaders(HeaderNames.ContentType, "x-custom-header") // obriga que a requisição tenha este header para ter permissão
													  // usar outras configurações e restrições
	.AllowAnyHeader());

});

builder.Services.ResolveDependecies();

//JWT
var appSettingsSection = builder.Configuration.GetSection("AppSettings");

builder.Services.Configure<AppSettings>(appSettingsSection);

builder.Services.AddSingleton(signingConfigurations);

builder.Services.AddSingleton(tokenConfigurations);

builder.Services.AddAuthentication(authOptions =>
{
	authOptions.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
	authOptions.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(bearerOptions =>
{
	var paramsValidation = bearerOptions.TokenValidationParameters;
	paramsValidation.IssuerSigningKey = signingConfigurations.Key;
	paramsValidation.ValidAudience = tokenConfigurations.Audience;
	paramsValidation.ValidIssuer = tokenConfigurations.Issuer;
	// Valida a assinatura de um token recebido
	paramsValidation.ValidateIssuerSigningKey = true;
	// Verifica se um token recebido ainda é válido
	paramsValidation.ValidateLifetime = true;
	// Tempo de tolerância para a expiração de um token (utilizado caso haja problemas de sincronismo de horário entre diferentes computadores envolvidos no processo de comunicação)
	paramsValidation.ClockSkew = TimeSpan.Zero;
});
// Configure services to the container (Configure).
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseDeveloperExceptionPage();
}
else
{
	app.UseExceptionHandler("/erro/500");
	app.UseStatusCodePagesWithRedirects("/erro/{0}");
	app.UseHsts();
}

//app.UseMiddleware<ExceptionMiddleware>();

app.UseSwaggerConfig(app.Environment);

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
	endpoints.MapControllers();
});

app.Run();
