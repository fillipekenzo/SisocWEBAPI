using Microsoft.EntityFrameworkCore;
using SISOC.Business.Interface;
using SISOC.Business.Models;
using SISOC.Business.Models.Interface;
using SISOC.Data.Context;
using System.Linq.Expressions;

namespace SISOC.Data.Repository
{
	public class OcorrenciaRepository : Repository<Ocorrencia>, IOcorrenciaRepository
	{
		public OcorrenciaRepository(SisocDbContext db) : base(db)
		{

		}
		public override async Task<List<Ocorrencia>> ObterTodos()
		{
			try
			{
				return await Db.Ocorrencias.Include(i => i.SetorNavigation).Include(i => i.TipoOcorrenciaNavigation).Include(i => i.UsuarioAtribuidoNavigation).Include(i => i.UsuarioCadastroNavigation).ToListAsync();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public virtual async Task<Ocorrencia> ObterPorID(int id)
		{
			try
			{
				return await Db.Ocorrencias.Include(o => o.Anexos).Include(o => o.UsuarioCadastroNavigation).Include(o => o.UsuarioAtribuidoNavigation).Where(o => o.OcorrenciaID == id).FirstOrDefaultAsync();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
