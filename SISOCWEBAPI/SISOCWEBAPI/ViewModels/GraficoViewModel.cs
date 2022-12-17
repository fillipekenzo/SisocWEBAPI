using System.ComponentModel.DataAnnotations;

namespace SISOCWEBAPI.ViewModels
{
	public class GraficoViewModel
	{
		public string[] Meses { get; set; }
		public int[] QuantidadeAberto { get; set; }
		public int[] QuantidadeEmAtendimento { get; set; }
		public int[] QuantidadeResolvido { get; set; }
	}
}
