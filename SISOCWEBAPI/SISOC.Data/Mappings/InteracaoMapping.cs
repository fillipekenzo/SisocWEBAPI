using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SISOC.Business.Models;

namespace SISOC.Data.Mappings
{
	public class InteracaoMapping : IEntityTypeConfiguration<InteracaoOcorrencia>
	{
		public void Configure(EntityTypeBuilder<InteracaoOcorrencia> builder)
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
