using Background_ProFinder.Models.DBModel;
using Background_ProFinder.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Background_ProFinder.Repositories
{
    public class GeneralRepository : IGeneralRepository
    {
        protected ThirdGroupContext _context;
        protected readonly ILogger _logger;
        public GeneralRepository(ThirdGroupContext context, ILogger logger)
        {
            _context = context;
            _logger = logger;
        }

        public virtual void Create<T>(T entity) where T : class
        {
            try
            {
                _context.Entry(entity).State = EntityState.Added;
                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Create method error", typeof(T));

            }
        }

        public virtual void Update<T>(T entity) where T : class
        {

            try
            {
                _context.Entry(entity).State = EntityState.Modified;
                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Update method error", typeof(T));

            }


        }

        public virtual void Delete<T>(T entity) where T : class
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    _context.Entry(entity).State = EntityState.Deleted;
                    _context.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "{Repo} Delete method error", typeof(T));
                    transaction.Rollback();
                }
            }
        }

        public virtual IQueryable<T> GetAll<T>() where T : class
        {
            try
            {
                return _context.Set<T>();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} GetAll method error", typeof(T));
                return null;
            }

        }

        public virtual void SaveChanges()
        {
            _context.SaveChanges();
        }

    }
}
