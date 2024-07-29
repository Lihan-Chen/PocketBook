using System.Threading.Tasks;
using PocketBook.Models;

namespace PocketBook.Core.IRepositories
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<string> GetFullName(Guid id);
    }
}
