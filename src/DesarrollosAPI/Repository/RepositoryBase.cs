using DesarrollosAPI.Contracts;
using DesarrollosAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DesarrollosAPI.Repository
{
    public class RepositoryBase<T>:IRepositoryBase<T> where T : class
    {
        protected RepositoryContext RepositoryContext { get; set; }
        public RepositoryBase(RepositoryContext repositoryContext)
        {
            RepositoryContext = repositoryContext;
        }

        public void Create(T entity)
        {
            RepositoryContext.Set<T>().Add(entity);
        }

        public IQueryable<T> GetById(Expression<Func<T, bool>> filter) {
            return RepositoryContext.Set<T>().Where(filter).AsNoTracking();
        }

        public IQueryable<T> GetAll()
        {
            return RepositoryContext.Set<T>().AsNoTracking();
        }

        public void Update(T entity)
        {
            RepositoryContext.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            RepositoryContext.Set<T>().Remove(entity);
        }

        public T GetEntity(Expression<Func<T, bool>> expression)
        {
            return RepositoryContext.Set<T>().First(expression);
        }
    }
}
