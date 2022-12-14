using DesarrollosAPI.Contracts;
using DesarrollosAPI.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DesarrollosAPI.Persistence
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
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

        virtual public async Task<T> GetById(Expression<Func<T, bool>> filter)
        {
            return await RepositoryContext.Set<T>().Where(filter).AsNoTracking().FirstAsync();
        }

        virtual public async Task<IList<T>> GetAll()
        {
            return await RepositoryContext.Set<T>().AsNoTracking().ToListAsync();
        }

        public void Update(T entity)
        {
            RepositoryContext.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            RepositoryContext.Set<T>().Remove(entity);
        }
    }
}
