using System;
using System.Threading.Tasks;

namespace EasyJob_Business.Models.Addresses.Services
{
    public interface IAddressService : IDisposable
    {
        Task Add(Adress adress);
        Task Update(Adress adress);
        Task Remove(Guid adresId);
    }
}
