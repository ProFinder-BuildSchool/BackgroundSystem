using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Background_ProFinder.Repositories
{
    public interface IGeneralRepository
    {
        void Create<T>(T entity) where T : class;

        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        IQueryable<T> GetAll<T>() where T : class;
    }
}
