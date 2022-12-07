using SISOC.Business.Interface;
using SISOC.Business.Models;
using SISOC.Util.Criptografia;

namespace SISOC.Business.Service
{
	public class UsuarioService : BaseService, IUsuarioService
	{
		private readonly IUsuarioRepository _usuarioRepository;
		private readonly ITipoUsuarioRepository _tipoUsuarioRepository;

		public UsuarioService(INotificador notificador,
			IUsuarioRepository usuarioRepository,
			ITipoUsuarioRepository tipoUsuarioRepository
			) : base(notificador)
		{
			_usuarioRepository = usuarioRepository;
			_tipoUsuarioRepository = tipoUsuarioRepository;
		}
		public async Task<bool> Cadastrar(Usuario usuario)
		{
			var tipoUsuario = _tipoUsuarioRepository.Buscar(t => t.Nome.ToUpper() == "ESTUDANTE").Result.FirstOrDefault();
			usuario.TipoUsuarioID = tipoUsuario.TipoUsuarioID;
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
		public async Task<bool> PostUsuario(Usuario usuario)
		{
			usuario.Senha = Cripto.HashPassword(usuario.Senha);
			await _usuarioRepository.Adicionar(usuario);
			return true;
		}

		public Task<List<Usuario>> GetAll()
		{
			throw new NotImplementedException();
		}
	}
}
