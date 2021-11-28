using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EasyJob_Business.Core.Data;

namespace EasyJob_Business.Models.Addresses
{
    public interface IAddressRepository:IRepository<Adress>
    {
        //TODO: fazer o repository

        Task<Adress> GetUserAddress(Guid id);
        
        Task<IEnumerable<Adress>> GetAddressJobs(string cidade);
               
    }
}

