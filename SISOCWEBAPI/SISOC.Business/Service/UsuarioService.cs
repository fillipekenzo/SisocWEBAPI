using SISOC.Business.Interface;
using SISOC.Business.Models;
using SISOC.Util.Criptografia;

namespace SISOC.Business.Service
{
	public class UsuarioService : BaseService, IUsuarioService
	{
		private readonly IUsuarioRepository _usuarioRepository;

		public UsuarioService(INotificador notificador,
			IUsuarioRepository usuarioRepository) : base(notificador)
		{
			_usuarioRepository = usuarioRepository;
		}
		public async Task<bool> Cadastrar(Usuario usuario)
		{
			usuario.TipoUsuarioID = 3;
			usuario.Senha = Cripto.HashPassword(usuario.Senha);
			await _usuarioRepository.Adicionar(usuario);
			return true;
		}

		public async Task<Usuario> Login(Usuario usuarioLogin)
		{
			var usuario = _usuarioRepository.GetByEmail(usuarioLogin.Email).Result.FirstOrDefault();

			if (usuario == null)
			{
				throw new Exception("E-mail ou senha incorretos");
			}
			else if (!Cripto.VerifyHashedPassword(usuario.Senha, usuarioLogin.Senha))
			{
				throw new Exception("E-mail ou senha incorretos");
			}
			else
			{
				return usuario;
			}
		}

		public Task<List<Usuario>> GetAll()
		{
			throw new NotImplementedException();
		}
	}
}
