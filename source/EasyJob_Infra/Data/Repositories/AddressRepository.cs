using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyJob_Business.Models;
using EasyJob_Business.Models.Addresses;
using EasyJob_Infra.Data.DbAplications;
using Microsoft.EntityFrameworkCore;

namespace EasyJob_Infra.Data.Repositories
{
    public class AddressRepository : Repository<Adress>, IAddressRepository
    {
        public AddressRepository(DbApplication context) : base(context) { }

        public async Task<Adress> GetUserAddress(Guid id)
        {
            return await Db.Adresses.AsNoTracking()
                .Include(u => u.User)
                .FirstOrDefaultAsync(x => x.UserId == id);
        }

        public async Task<IEnumerable<Adress>> GetAddressJobs(string cidade)
        {
            return await Db.Adresses.AsNoTracking()
               .Include(u => u.Job)
               .Where(x => x.City == cidade)
               .ToListAsync();

        }


    }
}
