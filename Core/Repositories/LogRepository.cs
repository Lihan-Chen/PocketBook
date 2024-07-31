using Microsoft.EntityFrameworkCore;
using PocketBook.Core.IRepositories;
using PocketBook.Data;
using System;
using System.Linq.Expressions;
using PocketBook.Models;
using System.Net.WebSockets;

namespace PocketBook.Core.Repositories
{
    public class LogRepository<TEntity> : ILogRepository<TEntity> where TEntity : class
    {
        protected ApplicationDbContext _context;

        internal DbSet<TEntity> dbSet;

        protected readonly ILogger _logger;

        public LogRepository(ApplicationDbContext context, ILogger logger)
        {
            this._context = context;
            this.dbSet = context.Set<TEntity>();
            _logger = logger;
        }

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await dbSet.ToListAsync();
        }

        public virtual async Task<TEntity> GetByIdAsync(int facilNo, int logTypeNo, string eventID, int eventID_RevNo)
        {
            var result = await dbSet.FindAsync(facilNo, logTypeNo, eventID, eventID_RevNo);

            if (result == null)
            {
                throw new Exception($"{typeof(TEntity)}NotExist");
            }

            return result;
        }

        public virtual async Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate)
        {
            // return dbSet.Where(predicate).ToListAsync();
            return await dbSet.Where(predicate).ToListAsync();
        }

        public virtual async Task<bool> AddAsync(TEntity entity)
        {
            await dbSet.AddAsync(entity);
            return true;
        }

        public virtual Task<bool> DeleteAsync(int facilNo, int logTypeNo, string eventID, int eventID_RevNo)
        {
            throw new NotImplementedException();
        }


        public virtual Task<bool> UpsertAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
