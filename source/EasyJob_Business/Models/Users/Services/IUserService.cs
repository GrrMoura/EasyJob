using System;
using System.Threading.Tasks;

namespace EasyJob_Business.Models.Users.Services
{
    public interface IUserService : IDisposable
    {
        Task Add(User user);
        Task Update(User user);
        Task Remove(Guid employerId);
    }
}
