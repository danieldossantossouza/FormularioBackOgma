using Microsoft.EntityFrameworkCore;
using QuestionarioBisiness.Interfaces;
using QuestionarioBisiness.Models;
using QuetionarioData.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QuetionarioData.Repository
{
	public class FormularioRepository : Repository<Formulario>, IFormularioRepository
	{
		public FormularioRepository(MeuDbContext context) : base(context) { }
		public async Task<Formulario> ObterPerguntaResposta(Guid id)
		{
			return await db.Formularios.AsNoTracking().Include(p => p.Pergunta)
				.FirstOrDefaultAsync(p=>p.Id == id);
		}

		//public Task<IEnumerable<Formulario>> ListaPerguntaRespostaPorId(Guid id)
		//{
		//	throw new NotImplementedException();
		//}

		//public Task<IEnumerable<Formulario>> ListaPerguntaresposta()
		//{

		//}

	}
}
