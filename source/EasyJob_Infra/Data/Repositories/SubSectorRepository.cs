using EasyJob.Domain.Interfaces;
using EasyJob_Business.Models.Subsectors;
using EasyJob_Infra.Data.DbAplications;

namespace EasyJob_Infra.Data.Repositories
{
    public class SubsectorRepository : Repository<Subsector>, ISubsectorRepository
    {
        public SubsectorRepository(DbApplication context) : base(context) { }
    }
}
