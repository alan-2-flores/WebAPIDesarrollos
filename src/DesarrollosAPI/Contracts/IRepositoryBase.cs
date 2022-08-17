using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DesarrollosAPI.Contracts
{
    public interface IRepositoryBase<T>
    {
        void Create(T entity);
        T GetEntity(Expression<Func<T, bool>> filter);
        Task<T> GetById(Expression<Func<T, bool>> filter);
        Task<IList<T>> GetAll();
        void Update(T entity);
        void Delete(T entity);
    }
}
