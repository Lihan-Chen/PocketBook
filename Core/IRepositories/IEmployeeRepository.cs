using PocketBook.Models;

namespace PocketBook.Core.IRepositories
{

    public interface IEmployeeRepository : IGenericRepository<Employee>
    {
        Task<string> GetFullName(int id);
    }
}
