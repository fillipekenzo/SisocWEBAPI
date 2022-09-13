using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace SISOCWEBAPI.DTOs
{
	public class SetorDTO
	{
		[Key]
		public int SetorID { get; set; }
		public string Nome { get; set; }
		public string Sigla { get; set; }
	}
}
