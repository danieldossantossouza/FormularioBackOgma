using System;

namespace QuestionarioBisiness.Models
{
	public class Formulario : Entity
	{
		public string Pergunta { get; set; }
		public string Resposta { get; set; }

		public TipoFormulario TipoFormulario { get; set; }
		public DateTime DataCriacao { get; set; }
		public DateTime DataExclucao { get; set; }

	}
}
