using Microsoft.EntityFrameworkCore;
using QuestionarioBisiness.Interfaces;
using QuestionarioBisiness.Models;
using QuetionarioData.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace QuetionarioData.Repository
{
	public abstract class Repository<T> : IRepository<T> where T : Entity , new()
	{
		protected readonly MeuDbContext db;
		protected readonly DbSet<T> dbset;
		public Repository(MeuDbContext _db)
		{
			db = _db;
			dbset = db.Set<T>();
		}
		public async Task<IEnumerable<T>> Buscar(Expression<Func<T, bool>> predicate)
		{
			return await dbset.AsNoTracking().Where(predicate).ToListAsync();
		}

		public virtual async Task<T> ObterPorId(Guid id)
		{
			return await dbset.FindAsync(id);
		}

		public virtual async Task<List<T>> ObterTodos()
		{
			return await dbset.ToListAsync();
		}

		public virtual async Task Adicionar(T t)
		{
			dbset.Add(t);
			await SaveChanges();
		}

		public async Task Atualizar(T t)
		{
			dbset.Update(t);
			await SaveChanges();
		}

		public async Task Remover(Guid id)
		{
			dbset.Remove(new T { Id =id});
			await SaveChanges();
		}

		public async Task<int> SaveChanges()
		{
			return await db.SaveChangesAsync();
		}
		public void Dispose()
		{
			db?.Dispose();
		}

	}
}
