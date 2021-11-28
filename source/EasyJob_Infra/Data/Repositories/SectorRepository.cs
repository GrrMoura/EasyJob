using EasyJob_Business.Models.Sectors;
using EasyJob_Infra.Data.DbAplications;

namespace EasyJob_Infra.Data.Repositories
{
    public class SectorRepository : Repository<Sector>, ISectorRepository
    {
        public SectorRepository(DbApplication context) : base(context) { }
    }
}
