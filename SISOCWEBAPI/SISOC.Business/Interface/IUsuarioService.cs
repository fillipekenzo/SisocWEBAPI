using SISOC.Business.Models;

namespace SISOC.Business.Interface
{
	public interface IUsuarioService
	{
		Task<bool> Cadastrar(Usuario usuario);
		Task<List<Usuario>> GetAll();
	}
}
