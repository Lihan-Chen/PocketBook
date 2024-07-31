using Microsoft.EntityFrameworkCore;
using PocketBook.Core.IRepositories;
using PocketBook.Data;
using PocketBook.Models;

namespace PocketBook.Core.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {

        public EmployeeRepository(
            ApplicationDbContext context,
            ILogger logger
            ) : base(context, logger)
        {

        }
        public Task<string> GetFullName(int id)
        {
            throw new NotImplementedException();
        }

        public override async Task<IEnumerable<Employee>> GetAllAsync()
        {
            try
            {
                return await dbSet.ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} GetAllAsync Method error", typeof(EmployeeRepository));

                // null
                return new List<Employee>();
            }
        }

        public override async Task<bool> UpsertAsync(Employee entity)
        {
            try
            {
                var existingEmployee = await dbSet.Where(x => x.Id == entity.Id).FirstOrDefaultAsync();

                if (existingEmployee == null)
                    return await AddAsync(entity);

                existingEmployee.FirstName = entity.FirstName;
                existingEmployee.LastName = entity.LastName;
                existingEmployee.FacilNo = entity.FacilNo;

                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} UpsertAsync Method error", typeof(EmployeeRepository));
                return false;
            }
        }

        public async Task<bool> DeleteAsync(int id)
        {
            try
            {
                var exist = await dbSet.Where(x => x.Id == id).FirstOrDefaultAsync();

                if (exist == null) return false;

                dbSet.Remove(exist);

                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} DeleteAsync Method error", typeof(EmployeeRepository));
                return false;
            }
        }
    }
}
