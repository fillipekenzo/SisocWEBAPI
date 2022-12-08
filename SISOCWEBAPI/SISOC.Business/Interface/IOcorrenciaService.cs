using SISOC.Business.Models;
using SISOC.Util.Consulta.Filtros;

namespace SISOC.Business.Interface
{
	public interface IOcorrenciaService
	{
		Task<bool> Post(Ocorrencia ocorrencia);
		Task<IEnumerable<Ocorrencia>> BuscarComFiltro(OcorrenciaFiltros concurso);
		Task EnviarEmailAtendimentoSetor(Ocorrencia ocorrencia);
		Task EnviarEmailEditarOcorrencia(Ocorrencia ocorrencia, string situacaoNova);

	}
}
