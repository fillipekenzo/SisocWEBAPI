using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using SISOC.Business.Interface;
using SISOC.Business.Models;
using SISOC.Business.Models.Validation;
using SISOCWEBAPI.DTOs;
using SISOCWEBAPI.Extensions;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace SISOCWEBAPI.Controllers
{
	[Route("sisocwebapi/v1/[controller]")]
	public class UsuarioController : MainController
	{
		private readonly AppSettings _appSettings;
		private readonly IWebHostEnvironment _env;
		private readonly IUsuarioService _usuarioService;
		private readonly IUsuarioRepository _usuarioRepository;
		private readonly IMapper _mapper;
		public UsuarioController(INotificador notificador,
							IOptions<AppSettings> appSettings,
							IUsuarioService usuarioService,
							IUsuarioRepository usuarioRepository,
							IMapper mapper,
							IWebHostEnvironment env) : base(notificador)
		{
			_appSettings = appSettings.Value;
			_env = env;
			_usuarioService = usuarioService;
			_usuarioRepository = usuarioRepository;
			_mapper = mapper;
		}

		[HttpPost("registrar")]
		public async Task<ActionResult> Registrar([FromBody] UsuarioRegistroDTO usuarioRegistroDTO)
		{
			try
			{
				if (!ModelState.IsValid) return CustomResponse(ModelState);


				UsuarioValidation validator = new UsuarioValidation();
				var resultValidateUser = validator.Validate(_mapper.Map<Usuario>(usuarioRegistroDTO));

				if (!resultValidateUser.IsValid)
				{
					NotificarErro(resultValidateUser.Errors.FirstOrDefault().ErrorMessage);
					return CustomResponse();
				}


				if (_usuarioRepository.Buscar((u) => u.Email == usuarioRegistroDTO.Email).GetAwaiter().GetResult().Any())
				{
					NotificarErro("O E-mail informado já possui um cadastro");
					return CustomResponse();
				}

				var result = await _usuarioService.Cadastrar(_mapper.Map<Usuario>(usuarioRegistroDTO));


				if (!result)
				{
					NotificarErro("Erro ao cadastrar");
					return CustomResponse();
				}

				if (result)
				{
					var usuario = _usuarioRepository.Buscar((u) => u.Email == usuarioRegistroDTO.Email).GetAwaiter().GetResult().FirstOrDefault();
					return CustomResponse(usuario);
				}

				return CustomResponse(usuarioRegistroDTO);
			}
			catch (Exception ex)
			{
				NotificarErro(ex.Message);
				return CustomResponse(ex);
			}
		}

		//[HttpPut]
		//public async Task<ActionResult> Put([FromBody] UserViewModel updateUser)
		//{
		//	try
		//	{
		//		if (!ModelState.IsValid) return CustomResponse(ModelState);

		//		ApplicationUser user = _aspNetUserRepository.Buscar((u) => u.Id == updateUser.Id).GetAwaiter().GetResult().FirstOrDefault();
		//		user.CPF = updateUser.CPF;
		//		user.Nome = updateUser.Nome;
		//		user.Email = updateUser.Email;
		//		user.UserName = updateUser.Email;

		//		ApplicationUserValidation validator = new ApplicationUserValidation();
		//		ValidationResult resultValidateUser = validator.Validate(user);

		//		if (!resultValidateUser.IsValid)
		//		{
		//			NotificarErro(resultValidateUser.Errors.FirstOrDefault().ErrorMessage);
		//			return CustomResponse();
		//		}


		//		if (_aspNetUserRepository.Buscar((u) => u.CPF == updateUser.CPF
		//		&& u.Id != updateUser.Id).GetAwaiter().GetResult().Any())
		//		{
		//			NotificarErro("CPF informado já consta nos dados de outro usuário");
		//			return CustomResponse();
		//		}

		//		var result = await _userManager.UpdateAsync(user);

		//		if (!result.Succeeded)
		//		{
		//			NotificarErro(result.Errors.FirstOrDefault().Description);
		//			return CustomResponse();
		//		}

		//		if (!_env.IsDevelopment())
		//			await _aspNetUserService.EnviarEmailLinkConfirmacao(user);

		//		return CustomResponse(updateUser);
		//	}
		//	catch (Exception ex)
		//	{
		//		NotificarErro(ex.Message);
		//		return CustomResponse(ex);
		//	}
		//}

		//[HttpPost("login")]
		//public async Task<ActionResult> Login(LoginViewModel loginViewModel)
		//{
		//	if (!ModelState.IsValid) return CustomResponse(ModelState);

		//	var result = await _signInManager.PasswordSignInAsync(loginViewModel.Email, loginViewModel.Password, isPersistent: false, lockoutOnFailure: true);
		//	var user = await _aspNetUserService.GetUserPorEmail(loginViewModel.Email);
		//	if (result.Succeeded)
		//	{
		//		if (!_env.IsDevelopment())
		//		{
		//			if (user.EmailConfirmed)
		//			{
		//				await _logAtividadeService.Adicionar(new LogAtividade
		//				{
		//					CpfUsuario = user.CPF,
		//					UserID = user.Id,
		//					NomeUsuario = loginViewModel.Email,
		//					TipoAtividade = "Login",
		//					UsuarioInclusao = user.Nome
		//				});
		//			}
		//			else
		//			{
		//				NotificarErro("Usuário precisa confirmar e-mail!");
		//			}
		//		}
		//		else
		//		{
		//			await _logAtividadeService.Adicionar(new LogAtividade
		//			{
		//				CpfUsuario = user.CPF,
		//				UserID = user.Id,
		//				NomeUsuario = loginViewModel.Email,
		//				TipoAtividade = "Login",
		//				UsuarioInclusao = user.Nome
		//			});
		//		}

		//		return CustomResponse(user);
		//	}

		//	if (result.IsLockedOut)
		//	{
		//		var tempoRestante = user.LockoutEnd.Value.LocalDateTime - DateTime.Now;
		//		NotificarErro($"Usuário temporariamente bloqueado durante {tempoRestante.Minutes} minutos e {tempoRestante.Seconds} segundos por tentativas inválidas");
		//		return CustomResponse(loginViewModel);
		//	}

		//	NotificarErro("Usuário ou senha Incorretos!");
		//	return CustomResponse(loginViewModel);
		//}

		//[HttpGet("esqueciSenha")]
		//public async Task<ActionResult> EsqueciSenha(string cpf, string email)
		//{
		//	ApplicationUser user = _aspNetUserRepository.Buscar((u) => u.CPF == cpf).GetAwaiter().GetResult().FirstOrDefault();

		//	if (user == null)
		//	{
		//		NotificarErro("CPF informado não consta na base de dados");
		//		return CustomResponse();
		//	}

		//	if (user.Email != email)
		//	{
		//		NotificarErro("E-mail informado não corresponde ao e-mail cadastrado neste CPF");
		//		return CustomResponse();
		//	}

		//	if (user.DataExpiracaoLink > DateTime.Now)
		//	{
		//		NotificarErro("Um e-mail para alteração de senha ja foi enviado.");
		//		return CustomResponse();
		//	}

		//	if (!_env.IsDevelopment())
		//		await _aspNetUserService.EnviarEmailEsqueciSenha(user);


		//	return CustomResponse(user);
		//}

		//[HttpPost("alterarSenha")]
		//public async Task<ActionResult> AlterarSenha(string cpf, string senha, string senhaConfirmada)
		//{
		//	try
		//	{
		//		ApplicationUser user;
		//		if (!_env.IsDevelopment())
		//			user = _aspNetUserRepository.ObterTodos().GetAwaiter().GetResult().Where(p => Crypto.VerifyHashedPassword(cpf, p.CPF)).FirstOrDefault();
		//		else
		//			user = _aspNetUserRepository.Buscar((u) => u.CPF == cpf).GetAwaiter().GetResult().FirstOrDefault();


		//		if (user == null)
		//		{
		//			NotificarErro("CPF informado não consta na base de dados");
		//			return CustomResponse();
		//		}

		//		if (user.DataExpiracaoLink.AddMinutes(30) < DateTime.Now)
		//		{
		//			NotificarErro("Link de alteração de senha expirado.");
		//			return CustomResponse();
		//		}

		//		if (senha != senhaConfirmada)
		//		{
		//			NotificarErro("As senhas não são correspondentes");
		//			return CustomResponse();
		//		}
		//		var result = await _userManager.PasswordValidators[0].ValidateAsync(_userManager, user, senha);
		//		if (!result.Succeeded)
		//		{
		//			NotificarErro(result.Errors.FirstOrDefault().Description);
		//			return CustomResponse();
		//		}

		//		user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, senha);
		//		await _userManager.UpdateAsync(user);

		//		return CustomResponse(user);
		//	}
		//	catch (Exception ex)
		//	{
		//		NotificarErro(ex.Message);
		//		return CustomResponse();
		//	}
		//}

		private string GerarJwt()
		{
			var tokenHandler = new JwtSecurityTokenHandler();
			var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
			var token = tokenHandler.CreateToken(new SecurityTokenDescriptor
			{

				Issuer = _appSettings.Emissor,
				Audience = _appSettings.ValidoEm,
				Expires = DateTime.UtcNow.AddHours(_appSettings.ExpiracaoHoras),
				SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), algorithm: SecurityAlgorithms.HmacSha256Signature)
			});

			var encodedToken = tokenHandler.WriteToken(token);
			return encodedToken;
		}

	}
}
