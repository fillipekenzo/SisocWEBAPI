using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SISOC.Business.Models;

namespace SISOC.Data.Mappings
{
	public class UsuarioMapping : IEntityTypeConfiguration<Usuario>
	{
		public void Configure(EntityTypeBuilder<Usuario> builder)
		{
			builder.Property(c => c.Senha)
				.IsRequired()
				.HasColumnType("nvarchar(500)");

			builder.Property(c => c.SetorID)
				.IsRequired(false);

		}
	}
}
