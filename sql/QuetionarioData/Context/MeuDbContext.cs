using Microsoft.EntityFrameworkCore;
using QuestionarioBisiness.Models;
using System.Linq;

namespace QuetionarioData.Context
{
	public class MeuDbContext : DbContext
	{
		public MeuDbContext(DbContextOptions options) : base (options){ }

		public DbSet<Formulario> Formularios { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(typeof(MeuDbContext).Assembly);
			base.OnModelCreating(modelBuilder);
			//
			//Exemplo de Como não deixar deletar por cascata (exemplo abaixo)
			//foreach (var relationsship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys())) relationsship.DeleteBehavior = DeleteBehavior.ClientSetNull;
			//
			//Para não deixar criar com o nvarchar max alguma culuna que vc esqueceu de mapear(exemplo abaixo)
			//foreach (var property in modelBuilder.Model.GetEntityTypes()
			//	.SelectMany(e => e.GetProperties()
			//	.Where(p => p.ClrType == typeof(string))))
			//	property.Relational().ColumnType = "varchar(100)";

		}

	}
}
