using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace SISOC.Business.Models
{
	[Table("Usuario")]
	public class ApplicationUser : IdentityUser
	{
	}
}
