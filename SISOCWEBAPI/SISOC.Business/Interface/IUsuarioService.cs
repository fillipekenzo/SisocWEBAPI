using SISOC.Business.Models;

namespace SISOC.Business.Interface
{
	public interface IUsuarioService
	{
		Task<bool> Cadastrar(Usuario usuario);
		Task<Usuario> Login(Usuario usuarioLogin);
		Task<List<Usuario>> GetAll();
	}
}
