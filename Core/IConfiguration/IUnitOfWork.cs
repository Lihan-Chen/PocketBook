using PocketBook.Core.IRepositories;

namespace PocketBook.Core.IConfiguration
{
    public interface IUnitOfWork
    {

        // Add all IRepositories here
        IUserRepository Users { get; }

        IMeterRepository Meters { get; }

        Task CompleteAsync(); 
    }
}
