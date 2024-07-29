using Microsoft.EntityFrameworkCore;
using PocketBook.Core.IRepositories;
using PocketBook.Data;
using PocketBook.Migrations;
using System.Linq.Expressions;

namespace PocketBook.Core.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected ApplicationDbContext _context;

        internal DbSet<T> dbSet;

        protected readonly ILogger _logger;

        public GenericRepository(ApplicationDbContext context, ILogger logger)
        {
            this._context = context;            
            this.dbSet = context.Set<T>();
            _logger = logger;
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            return await dbSet.ToListAsync();
        }

        public virtual async Task<T> GetByIdAsync(Guid id)
        {
            return await dbSet.FindAsync(id); 
        }

        public async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate)
        {
            // return dbSet.Where(predicate).ToListAsync();
            return await dbSet.Where(predicate).ToListAsync();
        }

        public virtual async Task<bool> AddAsync(T entity)
        {
             await dbSet.AddAsync(entity);
            return true;
        }

        public virtual Task<bool> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public virtual Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public virtual Task<bool> DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public virtual Task<bool> UpsertAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
