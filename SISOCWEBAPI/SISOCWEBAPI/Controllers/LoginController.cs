using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SISOC.Business.Interface;
using SISOC.Util.Configuration;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Principal;

namespace SISOCWEBAPI.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class LoginController : MainController
	{
		public LoginController(INotificador notificador) : base(notificador)
		{
		}

		//[HttpPost]
		//[Route("validarusuario")]
		//public async Task<ActionResult> Login(LoginDTO login, [FromServices] SigningConfiguration signingConfigurations, [FromServices] TokenConfiguration tokenConfigurations)
		//{
		//	try
		//	{
		//		var user = await _gsiClient.GetUsuario(login.Dominio, login.Usuario, login.Senha);

		//		if (user != null && !user.IsInvalid)
		//		{
		//			ClaimsIdentity identity = new ClaimsIdentity(
		//				new GenericIdentity(user.Result.UsuarioID.ToString(), "Login"),
		//				new[] {
		//					new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString("N")),
		//					new Claim(JwtRegisteredClaimNames.UniqueName, user.Result.UsuarioID.ToString())
		//				}
		//			);

		//			DateTime dataCriacao = DateTime.Now;
		//			DateTime dataExpiracao = dataCriacao +
		//				TimeSpan.FromSeconds(tokenConfigurations.Seconds);

		//			var handler = new JwtSecurityTokenHandler();
		//			var securityToken = handler.CreateToken(new SecurityTokenDescriptor
		//			{
		//				Issuer = tokenConfigurations.Issuer,
		//				Audience = tokenConfigurations.Audience,
		//				SigningCredentials = signingConfigurations.SigningCredentials,
		//				Subject = identity,
		//				NotBefore = dataCriacao,
		//				Expires = dataExpiracao
		//			});

		//			var token = handler.WriteToken(securityToken);
		//			return CustomResponse(new
		//			{
		//				usuarioID = user.Result.UsuarioID,
		//				nomeUsuario = user.Result.NomeUsuario,
		//				loginAD = user.Result.LoginAD,
		//				nomeDominio = user.Result.NomeDominio,
		//				geoEstruturaID = user.Result.GEOEstruturaID,
		//				email = user.Result.Email,
		//				telefoneResidencial = user.Result.TelefoneResidencial,
		//				telefoneCelular = user.Result.TelefoneCelular,
		//				telefoneComercial = user.Result.TelefoneComercial,
		//				cpf = user.Result.CPF,
		//				dataNascimento = user.Result.DataNascimento,
		//				matricula = user.Result.Matricula,
		//				authenticated = true,
		//				created = dataCriacao.ToString("yyyy-MM-dd HH:mm:ss"),
		//				expiration = dataExpiracao.ToString("yyyy-MM-dd HH:mm:ss"),
		//				access_token = token,
		//				message = "Usuário autenticado com sucesso.",
		//				menu = ""
		//			});
		//		}
		//		else
		//		{
		//			return CustomResponse(new
		//			{
		//				authenticated = false,
		//				message = "Falha ao autenticar o usuário."
		//			});
		//		}
		//	}
		//	catch (Exception e)
		//	{
		//		NotificarErro(e.Message);
		//		return CustomResponse();
		//	}
		//}
	}
}