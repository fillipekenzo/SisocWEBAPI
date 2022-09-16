using System.ComponentModel;

namespace CONCURSOMS.Business.Models.Enumerador
{
	public class SISOCEnumerador
	{
		public enum EGrauParentescoResponsavel
		{
			[Description("MÃE")]
			Mae,
			[Description("PAI")]
			Pai,
			[Description("IRMÃO/IRMÃ")]
			irmaoIrma,
			[Description("AVÔ/AVÓ")]
			avo,
			[Description("TIO(A)")]
			tioTia,
			[Description("OUTRO")]
			Outros,
		}
		public enum EInstituicaoVinculo
		{
			[Description("ESCOLA")]
			Escola,
			[Description("UNIVERSIDADE")]
			Universidade,
			[Description("EMPRESA")]
			Empresa,
			[Description("OUTRA")]
			Outros,
		}
		public enum ESerieEscola
		{
			[Description("1º Ano - Médio")]
			PrimeiroAnoMedio,
			[Description("2º Ano - Médio")]
			SegundoAnoMedio,
			[Description("3º Ano - Médio")]
			TerceiroAnoMedio,
			[Description("6º Ano - Fundamental")]
			SextoAnoFundamental,
			[Description("7º Ano - Fundamental")]
			SetimoAnoFundamental,
			[Description("8º Ano - Fundamental")]
			OitavoAnoFundamental,
			[Description("9º Ano - Fundamental")]
			NonoAnoFundamental,
		}
		public enum ESituacaoInscricao
		{
			[Description("Admitida")]
			Admitida,
			[Description("Não Admitida")]
			NaoAdmitida,
			[Description("Em Conformidade")]
			EmConformidade,
			[Description("Não Conformidade")]
			NaoConformidade,
			[Description("Classificada")]
			Classificada,
			[Description("Desclassificada")]
			Desclassificada
		}

		public enum ESituacaoConcurso
		{
			[Description("Aberto")]
			Aberto,
			[Description("Em Andamento")]
			EmAndamento,
			[Description("Finalizado")]
			Finalizado,
		}
		public enum ESituacaoSeleaoENUM
		{
			[Description("A Selecionar")]
			ASelecionar,
			[Description("Aprovado")]
			Aprovado,
			[Description("Desclassificado")]
			Desclassificado,
		}
		public enum ESituacaoAvaliacaoENUM
		{
			[Description("Avaliar")]
			Avaliar,
			[Description("Em Avaliação")]
			EmAvaliacao,
			[Description("Avaliado")]
			Avaliado,
		}
	}
}
