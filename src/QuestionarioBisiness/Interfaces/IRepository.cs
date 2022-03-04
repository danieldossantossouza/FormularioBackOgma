﻿using QuestionarioBisiness.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace QuestionarioBisiness.Interfaces
{
	public interface IRepository<T> : IDisposable where T : Entity
	{
		Task Adicionar(T t);
		Task<T> ObterPorId(Guid id);
		Task<List<T>> ObterTodos();
		Task Atualizar(T t);
		Task Remover(Guid id);
		Task<IEnumerable<T>> Buscar(Expression<Func<T, bool>> predicate);
		Task<int> SaveChanges();

	}
}
