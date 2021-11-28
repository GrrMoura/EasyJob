using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyJob_Business.Models.Addresses;
using EasyJob_Business.Models.Sectors;
using EasyJob_Business.Models.Subsectors;
using EasyJob_Business.Models.Vacancies.Jobs;
using EasyJob_Infra.Data.DbAplications;
using Microsoft.EntityFrameworkCore;

namespace EasyJob_Infra.Data.Repositories
{
    public class JobRepository : Repository<Job>, IJobRepository
    {
        public JobRepository(DbApplication Context) : base(Context) { }


        public async Task<Job> GetJobAddress(Guid id)
        {
            return await Db.Jobs.AsNoTracking()
                .Where(i => id == i.Id)
                 .Include(a => a.Adress)
                  .FirstOrDefaultAsync(e => e.Id == id);
        }


        public async Task<Job> GetJobAddressUser(Guid id)
        {
            return await Db.Jobs.AsNoTracking()
                 .Include(a => a.Adress)
                 .Include(u => u.User)
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<IEnumerable<Job>> GetJobsAddressUsers()
        {

            return await Db.Jobs.AsNoTracking()
                 .Include(a => a.Adress)
                 .Include(u => u.User)
                 .OrderBy(o => o.CreationTime).Reverse()
                 .ToListAsync();
        }

        public async Task<IEnumerable<Job>> GetJobsById(Guid userId)
        {
            return await Db.Jobs.AsNoTracking()
                .Where(a => userId == a.UserId)
                .OrderBy(v => v.CreationTime).Reverse().ToListAsync();

        }

        //TODO: subsector nem subsector não é mais necessário, fazer com que o subsector seja pego pelo endereço


        public async Task<Job> GetJobAdressSector(Guid id)
        {
            return await Db.Jobs.AsNoTracking()
                   .Include(a => a.Adress)
                   .Include(s => s.Subsector)
                  .FirstOrDefaultAsync(v => v.Id == id);

        }

        public async Task<Job> GetJobById(Guid id)
        {
            return await Db.Jobs.AsNoTracking()
                        .FirstOrDefaultAsync(v => v.Id == id);

        }
        public async Task<IEnumerable<Job>> GetJobsBySector(Sector sector)
        {
            return await Search(v => v.Subsector.SectorId == sector.Id);
        }


        public async Task<Job> GetJobSectorAddressSubsectorUser(Guid id)
        {
            return await Db.Jobs.AsNoTracking()
                  .Include(s => s.Subsector)
                  .Include(a => a.Adress)
                  .Include(su => su.Subsector)
                  .Include(e => e.UserId)
                 .FirstOrDefaultAsync(v => v.Id == id);
        }

        public Task<IEnumerable<Job>> GetJobsByTitle(string Title)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Job>> GetJobsBySubsector(Guid SubsectorId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Job>> GetJobsByAddress(Adress adress)
        {
            throw new NotImplementedException();

        }

        public Task<IEnumerable<Job>> GetJobsBySubsector(Subsector Subsector)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Job>> IJobRepository.GetJobsAddresses()
        {
            throw new NotImplementedException();
        }
    }
}
