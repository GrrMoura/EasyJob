using EasyJob_Business.Core.NotificationsErrors;
using EasyJob_Business.Core.Services;
using EasyJob_Business.Models.Addresses.Validations;
using EasyJob_Business.Models.Users.Validations;
using EasyJob_Business.Models.Vacancies.Jobs.Services;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace EasyJob_Business.Models.Users.Services
{
    public class UserService : BaseService, IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IJobService _jobService;

        public UserService(IUserRepository employerRepository,
                           IJobService jobService,
                           INotifier notifier) : base(notifier)
        {
            _userRepository = employerRepository;
            _jobService = jobService;
        }

        public async Task Add(User user)
        {
            if (!RunValidation(new UserValidation(), user)
             && (!RunValidation(new AdressValidation(), user.Address))) ;

            if (await ExistingEmployer(user) == true) return;

            await _userRepository.Add(user);
        }

        public async Task Update(User user)
        {
            if (!RunValidation(new UserValidation(), user)) return;

            await _userRepository.Update(user);


        }

        public async Task Remove(Guid userId)
        {
            var user = await _userRepository.GetUserAddressJob(userId);

            if (user.Jobs.Any())
            {
                Notify("O Empregador possui Vaga cadastrada ");

                foreach (var job in user.Jobs)
                {
                    await _jobService.Remove(job.Id);// vê onde pego o job id
                }
            }

            user.Active = false;
            await _userRepository.Update(user);
        }

        private async Task<bool> ExistingEmployer(User user)
        {
            var currentEmployer = await _userRepository.Search(e => e.Email == user.Email && e.Id == user.Id);

            if (!currentEmployer.Any()) return false;

            Notify("Já Existe um Empregador com esse e-mail cadastrado");
            return true;
        }

        public void Dispose()
        {
            _userRepository?.Dispose();
        }

    }
}
