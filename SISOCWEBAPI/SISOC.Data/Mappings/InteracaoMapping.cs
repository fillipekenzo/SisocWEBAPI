using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SISOC.Business.Models;

namespace SISOC.Data.Mappings
{
	public class InteracaoMapping : IEntityTypeConfiguration<Interacao>
	{
		public void Configure(EntityTypeBuilder<Interacao> builder)
		{
			builder.Property(c => c.Assunto)
				.IsRequired()
				.HasColumnType("nvarchar(500)");

			builder.Property(c => c.Descricao)
				.IsRequired()
				.HasColumnType("nvarchar(MAX)");

			
		}
	}
}
