using EasyJob_Business.Core.NotificationsErrors;
using EasyJob_Business.Core.Services;
using Microsoft.AspNetCore.Http;
using System;
using System.Security.Claims;
using System.Threading.Tasks;
using EasyJob_Business.Models.Addresses.Services;

namespace EasyJob_Business.Models.Addresses.Service
{
    public class AddressService : BaseService, IAddressService
    {
        private readonly IAddressRepository _addressRepository;

        public AddressService(IAddressRepository addressRepository,
                              INotifier notifer) : base(notifer)
        {
            _addressRepository = addressRepository;
        }

        public async Task Add(Adress adress)
        {
            await _addressRepository.Add(adress);
        }


        public async Task Remove(Guid adresId)
        {
            await _addressRepository.Delete(adresId);
        }

        public async Task Update(Adress adress)
        {
            await _addressRepository.Update(adress);
        }

        public void Dispose()
        {
            _addressRepository?.Dispose();
        }
    }
}
