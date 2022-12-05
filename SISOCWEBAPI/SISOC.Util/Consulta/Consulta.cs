using SISOC.Util.Extensions;
using System.Collections;
using System.Reflection;

namespace SISOC.Util.Consulta
{
	public class Consulta<T> : IConsulta<T>
	{


		public IEnumerable<T> Filtrar(IEnumerable<T> lista, object filtroModel)
		{
			return NavegarPelosFiltrosRecursivamente
				(lista, filtroModel, null, filtroModel.GetType().GetProperties().FirstOrDefault());
		}

		/// <summary> 
		/// Esse método navega por todos atributos e atributos de objetos que são atributos, 
		/// possibilitando passar uma model com objetos aninhados,
		/// e filtra a lista pelos valores desses atributos. O ideal é criar uma model nova para 
		/// utilizar nesse método pois geralmente as models de entidades já tem valores padrões que atrapalham a consutla.        
		/// </summary>
		public IEnumerable<T> NavegarPelosFiltrosRecursivamente(IEnumerable<T> lista, object filtroModel, List<string> nomesFiltros,
			PropertyInfo filtro = null, int indiceFiltro = 0, int numeroObjetosAninhados = 0)
		{
			try
			{
				if (FaltamFiltrosParaSeremVerificados(filtroModel, indiceFiltro))
				{
					lista = NavegarPelosFiltrosRecursivamente(lista, filtroModel, nomesFiltros, filtroModel.GetType().GetProperties().ElementAt(indiceFiltro + 1), indiceFiltro + 1, numeroObjetosAninhados);
				}
				if (FiltroEhObjetoDiferenteDeNull(filtroModel, filtro.Name) && !(filtroModel.GetValueProperty(filtro.Name) is ICollection))
				{
					if (nomesFiltros == null) nomesFiltros = new List<string>();
					lista = NavegarPelosFiltrosRecursivamente(lista, filtroModel.GetValueProperty(filtro.Name), nomesFiltros.Append(filtro.Name).ToList(), filtroModel.GetValueProperty(filtro.Name).GetType().GetProperties().FirstOrDefault(), 0, numeroObjetosAninhados + 1);
				}


				if (filtroModel.GetValueProperty(filtro.Name)?.isObject() == false)
				{
					List<string> novaListaNomes = nomesFiltros != null ? nomesFiltros.Append(filtro.Name).ToList() : new List<string> { filtro.Name };
					lista = lista.Where((x =>
					CompararValor(x, novaListaNomes, filtroModel.GetValueProperty(filtro.Name))
					));
				}
				return lista;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public object SelecionarAtributoASerComparado(object x, List<string> nomesFiltros)
		{
			object objetoASerComparado = x;
			foreach (string nome in nomesFiltros)
			{
				if (objetoASerComparado.GetType() == typeof(ICollection<object>))
				{
					var teste = true;
				}
				objetoASerComparado = objetoASerComparado.GetValueProperty(nome);
			}

			return objetoASerComparado;
		}

		public bool CompararValor(object x, List<string> nomesFiltros, object valorFiltro)
		{
			try
			{
				if (valorFiltro != null &&
					   valorFiltro.ToString() != "0"
					   && !String.IsNullOrEmpty(valorFiltro.ToString()))
				{
					object objetoASerComparado = SelecionarAtributoASerComparado(x, nomesFiltros);
					if (objetoASerComparado == null)
					{
						return false;
					}
					if (valorFiltro.GetType() == typeof(string))
					{
						return objetoASerComparado
						  .ToString().ToUpperRetirarAcento()
						  .Contains(valorFiltro.ToString().ToUpperRetirarAcento());

					}
					else
					{
						return objetoASerComparado.ToString() == valorFiltro.ToString();
					}
				}

				return true;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public int RetornaProximoIndice(object filtroModel, int indice)
		{
			if (FiltroEhObjetoDiferenteDeNull(filtroModel, filtroModel.GetType().GetProperties().ElementAt(indice).Name))
			{
				return indice;
			}
			return ++indice;
		}

		public bool FiltroEhObjetoDiferenteDeNull(object filtroModel, string filtroName)
		{
			return filtroModel.GetValueProperty(filtroName) != null && filtroModel.GetValueProperty(filtroName)?.isObject() == true;
		}
		public bool FaltamFiltrosParaSeremVerificados(object filtroModel, int indiceFiltro)
		{
			return filtroModel.GetType().GetProperties().Length + -indiceFiltro - 1 > 0;
		}
	}

}
