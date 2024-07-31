using System.Linq.Expressions;
using PocketBook.Models;
namespace PocketBook.Core.IRepositories
{
    public interface ILogRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAllAsync();

        Task<TEntity> GetByIdAsync(int facilNo, int logTypeNo, string eventID, int eventID_RevNo);

        Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate);

        Task<bool> AddAsync(TEntity entity);

        Task<bool> DeleteAsync(int facilNo, int logTypeNo, string eventID, int eventID_RevNo);

        Task<bool> UpsertAsync(TEntity entity);
    }
}
