using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using SISOC.Data.Data;
using SISOC.Util.Configuration;
using SISOCWEBAPI.Configurations;
using SISOCWEBAPI.Extensions;

var builder = WebApplication.CreateBuilder(args);

var tokenConfigurations = new TokenConfiguration();
new ConfigureFromConfigurationOptions<TokenConfiguration>(
				builder.Configuration.GetSection("TokenConfigurations"))
.Configure(tokenConfigurations);

var signingConfigurations = new SigningConfiguration();

// Add services to the container (ConfigureServices).
builder.Services.AddAutoMapper(typeof(Program).Assembly);

builder.Services.AddDbContext<SisocDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers().AddNewtonsoftJson(op => op.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerConfig();

builder.Services.AddSwaggerConfig();

builder.Services.ResolveDependecies();

//JWT
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
if (!app.Environment.IsDevelopment())
{
	app.UseCors("Desenvolvimento");
	app.UseDeveloperExceptionPage();
}
else
{
	app.UseCors("Production");
	app.UseHsts();
}

app.UseAuthentication();

app.UseMiddleware<ExceptionMiddleware>();

app.UseMvcConfiguration();

app.UseSwaggerConfig(app.Environment);

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
	endpoints.MapControllers();
});

app.Run();
