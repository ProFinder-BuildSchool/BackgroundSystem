using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Background_ProFinder.Repositories
{
    public interface IGeneralRepository<T> where T:class
    {
        void Create(T entity);

        void Update(T entity);
        void Delete(T entity);
        IQueryable<T> GetAll();
    }
}
