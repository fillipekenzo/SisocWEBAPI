using System.Text.RegularExpressions;

namespace SISOC.Util.Extensions
{
	public static class StringExtensions
	{
		public static string ToUpperRetirarAcento(this string texto)
		{
			texto = texto.ToUpper();
			texto = Regex.Replace(texto, "[ÀÁÂÃÄÅ]", "A");
			texto = Regex.Replace(texto, "[ÈÉÊË]", "E");
			texto = Regex.Replace(texto, "[ÍÌÎ]", "I");
			texto = Regex.Replace(texto, "[ÓÒÔ]", "O");
			texto = Regex.Replace(texto, "[ÙÚÛ]", "U");
			texto = Regex.Replace(texto, "[Ç]", "C");

			return texto;
		}

	}
}
