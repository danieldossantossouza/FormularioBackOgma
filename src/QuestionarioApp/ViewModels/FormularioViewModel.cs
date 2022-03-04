using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace QuestionarioApp.ViewModels
{
	public class FormularioViewModel 
	{
		[Key]
		public Guid Id { get; set; }

		[DisplayName("Escreva a Pergunta !")]
		[Required(ErrorMessage ="O Campo {0} é obrigatorio !")]
		public string Pergunta { get; set; }

		[DisplayName("Escreva a Resposta !")]
		public string Resposta { get; set; }

		[DisplayName("Tipo de Formulário")]
		public int TipoFormulario { get; set; }
		public DateTime DataCriacao { get; set; }
		public DateTime DataExclucao { get; set; }

	}
}
