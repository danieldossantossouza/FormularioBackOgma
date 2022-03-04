using QuestionarioBisiness.Models;
using System;
using System.Threading.Tasks;

namespace QuestionarioBisiness.Interfaces
{
	public interface IFormularioRepository : IRepository<Formulario>
	{
		//Task<IEnumerable<Formulario>> ListaPerguntaRespostaPorId(Guid id);
		//Task<IEnumerable<Formulario>> ListaPerguntaresposta();
		Task<Formulario> ObterPerguntaResposta(Guid id);

	}
}
