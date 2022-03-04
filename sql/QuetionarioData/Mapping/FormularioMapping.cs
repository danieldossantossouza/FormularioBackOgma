using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuestionarioBisiness.Models;

namespace QuetionarioData.Mapping
{
	public class FormularioMapping : IEntityTypeConfiguration<Formulario>
	{
		public void Configure(EntityTypeBuilder<Formulario> builder)
		{
			builder.HasKey(f => f.Id);
			builder.Property(f => f.Pergunta)
				.IsRequired()
				.HasColumnType("varchar(5000)");

			builder.Property(f => f.Resposta)
				.HasColumnType("varchar(5000)");

			builder.ToTable("Formularios");
		}
	}
}
