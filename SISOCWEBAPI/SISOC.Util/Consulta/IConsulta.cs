

namespace SISOC.Util.Consulta
{
	public interface IConsulta<T>
	{
		public IEnumerable<T> Filtrar(IEnumerable<T> lista, object filtroModel);
	}
}
