using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SISOC.Business.Models;

namespace SISOC.Data.Mappings
{
	public class OcorrenciaMapping : IEntityTypeConfiguration<Ocorrencia>
	{
		public void Configure(EntityTypeBuilder<Ocorrencia> builder)
		{
			builder.Property(c => c.Assunto)
				.IsRequired()
				.HasColumnType("nvarchar(500)");

			builder.Property(c => c.Descricao)
				.IsRequired()
				.HasColumnType("nvarchar(MAX)");

			builder.Property(c => c.Resolucao)
				.IsRequired(false)
				.HasColumnType("nvarchar(MAX)");
		}
	}
}
