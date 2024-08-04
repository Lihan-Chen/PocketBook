using Microsoft.EntityFrameworkCore;
using PocketBook.Core.IRepositories;
using PocketBook.Data;
using PocketBook.Models;
using System.Linq.Expressions;

namespace PocketBook.Core.Repositories
{
    public class AllEventRepository : LogRepository<AllEvent>, IAllEventRepository
    {
        public AllEventRepository(
            ApplicationDbContext context,
            ILogger logger
            ) : base(context, logger)
        {

        }


        public async Task<IEnumerable<AllEvent>> GetDefaultAllEvents(int facilNo, DateTime startDate, DateTime endDate)
        {
            return await dbSet.Where(x => x.FacilNo == facilNo & x.EventDate >= startDate & x.EventDate <= endDate).ToListAsync();

        }

        public async Task<bool> AddAsync(AllEvent entity)
        {
            await dbSet.AddAsync(entity); 
            return true;
        }

        public new Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public new Task<IEnumerable<AllEvent>> FindAsync(Expression<Func<AllEvent, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AllEvent>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<AllEvent> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpsertAsync(AllEvent entity)
        {
            throw new NotImplementedException();
        }

        public async Task<AllEvent> GetByIdAsync(int facilNo, int logTypeNo, string eventID, int eventID_RevNo)
        {
            return await dbSet.FirstOrDefaultAsync(x => x.FacilNo == facilNo & x.LogTypeNo == logTypeNo & x.EventID == eventID & x.EventID_RevNo == eventID_RevNo);
        }

        public async Task<bool> DeleteAync(int facilNo, int logTypeNo, string eventID, int eventID_RevNo)
        {
            try
            {
                var exist = await GetByIdAsync(facilNo, logTypeNo, eventID, eventID_RevNo);

                if (exist != null)
                {     
                    dbSet.Remove(exist);
                    return true;
                } else { return false;}
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} DeleteAsync Method error", typeof(EmployeeRepository));
                return false;
            }
        }
    }
}
