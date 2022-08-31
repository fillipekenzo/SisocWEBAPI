namespace SISOC.Business.Models
{
	public abstract class Entity
	{
		public DateTime DataHoraCadastro { get; set; }
		public DateTime DataHoraAlteracao { get; set; }
		public abstract void SetId(int id);
	}
}
