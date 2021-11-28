using EasyJob_Business.Core.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EasyJob_Business.Models.Users
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User> GetUserById(Guid id);
        Task<User> GetUserAddress(Guid id);
        Task<User> GetUserAddressJob(Guid id);

        Task<IEnumerable<User>> GetUserAddressJobs(Guid userId);
        Task<IEnumerable<User>> GetUsersAddress();

        Task<IEnumerable<User>> GetUsersJobsById(Guid id);

        Task<IEnumerable<User>> GetUserAddressJobs();



    }
}
