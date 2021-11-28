using EasyJob_Business.Models.Users;
using EasyJob_Infra.Data.DbAplications;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyJob_Infra.Data.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(DbApplication context) : base(context) { }


        public async Task<User> GetUserById(Guid id) 
        {
            return await Db.User.AsNoTracking()
                                .FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<User> GetUserAddress(Guid id) 
        {
            return await Db.User.AsNoTracking()
                .Include(e => e.Address)
               .FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<User> GetUserAddressJob(Guid id) //usando
        {
            return await Db.User.AsNoTracking()
                .Include(j => j.Jobs)
                .Include(e => e.Address)
                .FirstOrDefaultAsync(e => e.Id == id);
        }


        public async Task<IEnumerable<User>> GetUserAddressJobs()
        {
            return await Db.User.AsNoTracking()
                  .Include(a => a.Address)
                  .Include(j => j.Jobs)
                  .OrderBy(v => v.CreationTime).ToListAsync();
        }
        public async Task<IEnumerable<User>> GetUsersAddress()
        {
            return await Db.User.AsNoTracking()
                                .Include(a => a.Address)
                                .OrderBy(v => v.CreationTime).ToListAsync();
        }


        public async Task<IEnumerable<User>> GetUserAddressJobs(Guid userId)
        {
            return await Db.User.AsNoTracking()
                .Include(a => a.Address)
                .Include(j => j.Jobs)
                .OrderBy(v => v.CreationTime).ToListAsync();
        }

        public async Task<IEnumerable<User>> GetUsersJobsById(Guid id)
        {
            return await Db.User.AsNoTracking()
                    .Include(j => j.Jobs)
                    .Where(j => j.Id == id)
                    .OrderBy(o => o.CreationTime)
                    .ToListAsync();
        }
    }
}
