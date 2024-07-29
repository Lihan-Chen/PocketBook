using Microsoft.EntityFrameworkCore;
using PocketBook.Core.IRepositories;
using PocketBook.Data;
using PocketBook.Models;

namespace PocketBook.Core.Repositories
{
    public class MeterRepository : GenericRepository<Meter>, IMeterRepository
    {

        public MeterRepository(
            ApplicationDbContext context,
            ILogger logger
            ) : base(context, logger)
        {

        }
        //public Task<string> GetFullName(Guid id)
        //{
        //    throw new NotImplementedException();
        //}

        public override async Task<IEnumerable<Meter>> GetAllAsync()
        {
            try
            {
                return await dbSet.ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} GetAllAsync Method error", typeof(MeterRepository));

                // null
                return new List<Meter>();
            }
        }

        public override async Task<bool> UpsertAsync(Meter entity)
        {
            try
            {
                var existingMeter = await dbSet.Where(x => x.MeterID == entity.MeterID).FirstOrDefaultAsync();

                if (existingMeter == null)
                    return await AddAsync(entity);

                existingMeter.FacilNo = entity.FacilNo;
                existingMeter.MeterType = entity.MeterType;
                existingMeter.UpdateDate = DateTime.Now;

                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} UpsertAsync Method error", typeof(MeterRepository));
                return false;
            }
        }

        public override async Task<bool> DeleteAsync(string Id)
        {
            try
            {
                var exist = await dbSet.Where(x => x.MeterID == Id).FirstOrDefaultAsync();

                if (exist == null) return false;

                dbSet.Remove(exist);

                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} DeleteAsync Method error", typeof(MeterRepository));
                return false;
            }
        }
    }
}
