
using EasyJob_Business.Core.NotificationsErrors;
using EasyJob_Business.Core.Services;
using EasyJob_Business.Models.Vacancies.Jobs.Validations;
using System;
using System.Threading.Tasks;

namespace EasyJob_Business.Models.Vacancies.Jobs.Services
{
    public class JobService : BaseService, IJobService
    {
        private readonly IJobRepository _jobRepository;


        public JobService(IJobRepository jobRepository, INotifier notifier) : base(notifier)
        {
            _jobRepository = jobRepository;
        }

        public async Task Add(Job job)
        {

            if (!RunValidation(new JobValidation(), job)) return;
            //&&  !RunValidation(new AdressValidation(), job.Address,
            //&& !RunValidation(new SectorValidation(), job.Sector,
            //&& !RunValidation(new SubSectorValidation(), job.subsector,

            try
            {
                await _jobRepository.Add(job);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return;
            }

        }

        public async Task Update(Job job)
        {
            if (!RunValidation(new JobValidation(), job)) return;
            //&&  !RunValidation(new AdressValidation(), job.Address,
            //&& !RunValidation(new SectorValidation(), job.Sector,
            //&& !RunValidation(new SubSectorValidation(), job.subsector,

            await _jobRepository.Update(job);
        }

        public async Task Remove(Guid jobId)
        {
            await _jobRepository.Delete(jobId);
        }


        public void Dispose()
        {
            _jobRepository?.Dispose();
        }


    }
}
