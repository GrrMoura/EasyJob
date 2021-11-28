using EasyJob_Business.Core.Data;
using EasyJob_Business.Models.Addresses;
using EasyJob_Business.Models.Sectors;
using EasyJob_Business.Models.Subsectors;
using EasyJob_Business.Models.Users;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EasyJob_Business.Models.Vacancies.Jobs

{
    public interface IJobRepository : IRepository<Job>
    {
        //TODO: limpar esse código

        Task<Job> GetJobAddressUser(Guid id);
        Task<Job> GetJobById(Guid id);
        Task<IEnumerable<Job>> GetJobsAddressUsers();


        Task<Job> GetJobAddress(Guid id);
       

        Task<IEnumerable<Job>> GetJobsAddresses();
        Task<IEnumerable<Job>> GetJobsById(Guid userId); 

        Task<Job> GetJobAdressSector(Guid id);

        Task<IEnumerable<Job>> GetJobsByAddress(Adress adress);
        Task<IEnumerable<Job>> GetJobsByTitle(string Title);
        Task<IEnumerable<Job>> GetJobsBySubsector(Subsector subsector);
    }
}
