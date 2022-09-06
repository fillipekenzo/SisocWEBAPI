using SISOC.Business.Models;
using System.ComponentModel.DataAnnotations;

namespace SISOCWEBAPI.ViewModels
{
	public class UsuarioViewModel
	{
		public int UsuarioID { get; set; }
		public string Nome { get; set; }
		public string Email { get; set; }
		public TipoUsuario TipoUsuario { get; set; }
	}
}
