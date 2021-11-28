using EasyJob_Business.Models.Vacancies.Jobs;
using System;
using System.Threading.Tasks;

namespace EasyJob_Business.Models.Vacancies.Jobs.Services
{
    public interface IJobService:IDisposable
    {
        Task Add(Job job);
        Task Update(Job job);
        Task Remove(Guid JobId);


    }
}
