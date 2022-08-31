using SISOC.Business.Interface;
using SISOC.Business.Models;

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
			await _usuarioRepository.Adicionar(usuario);
			return true;
		}

		public Task<List<Usuario>> GetAll()
		{
			throw new NotImplementedException();
		}
	}
}
