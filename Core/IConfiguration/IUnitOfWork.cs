using PocketBook.Core.IRepositories;

namespace PocketBook.Core.IConfiguration
{
    public interface IUnitOfWork
    {

        // Add all IRepositories here
        IUserRepository Users { get; }

        IEmployeeRepository Employees { get; }

        IMeterRepository Meters { get; }

        IAllEventRepository AllEvents { get; }



        Task CompleteAsync(); 
    }
}
