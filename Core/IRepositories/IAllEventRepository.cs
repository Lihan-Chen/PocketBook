using PocketBook.Models;

namespace PocketBook.Core.IRepositories
{
    public interface IAllEventRepository: ILogRepository<AllEvent>
    {
        // Task<IEnumerable<AllEvent>> GetDefaultAllEvents(int facilNo, DateTime startDate, DateTime endDate);

    }
}
