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
    public class GeneralRepository<T>:IGeneralRepository<T> where T: class
    {
        protected ThirdGroupContext _context;
        protected readonly ILogger _logger;
        public GeneralRepository(ThirdGroupContext context, ILogger<T> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void Create(T entity)
        {
            try
            {
                _context.Entry(entity).State = EntityState.Added;
                _context.SaveChanges();
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, "{Repo} Create method error", typeof(T));
            }
            
        }

        public void Update(T entity)
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

        public void Delete(T entity)
        {
            try
            {
                _context.Entry(entity).State = EntityState.Deleted;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Delete method error", typeof(T));
            }
        }

        public IQueryable<T> GetAll()
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
    }
}
