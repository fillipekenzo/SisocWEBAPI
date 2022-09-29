using System.ComponentModel;

namespace CONCURSOMS.Business.Models.Enumerador
{
	public class SISOCEnumerador
	{
		public enum ESituacaoOcorrencia
		{
			[Description("Aberto")]
			Aberto,
			[Description("Em Atendimento")]
			EmAtendimento,
			[Description("Resolvido")]
			Resolvido,
		}
		public enum EUrgenciaOcorrencia
		{
			[Description("Alta")]
			Alta,
			[Description("Média")]
			Media,
			[Description("Baixa")]
			Baixa,
		}
	}
}
