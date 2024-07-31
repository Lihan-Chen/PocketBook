using System.Linq.Expressions;

namespace PocketBook.Core.IRepositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();

        Task<T> GetByIdAsync(int id);

        Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate);

        Task<bool> AddAsync(T entity);

        Task<bool> DeleteAsync(int id);

        Task<bool> UpsertAsync(T entity);
    }
}
