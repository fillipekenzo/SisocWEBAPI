using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SISOC.Data.Data;
using SISOC.Util.Configuration;
using SISOCWEBAPI.Configurations;
using SISOCWEBAPI.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container (ConfigureServices).
builder.Services.AddAutoMapper(typeof(Program).Assembly);

builder.Services.AddDbContext<SisocDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddIdentityConfiguration(builder.Configuration);

builder.Services.AddControllers().AddNewtonsoftJson(op => op.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerConfig();

builder.Services.AddSwaggerConfig();

builder.Services.ResolveDependecies();

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
