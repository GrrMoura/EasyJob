using AutoMapper;
using EasyJob.AppMVC.ViewModel;
using EasyJob_Business.Models.Addresses.Services;
using EasyJob_Business.Models.Users;
using EasyJob_Business.Models.Vacancies.Jobs;
using EasyJob_Business.Models.Vacancies.Jobs.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace EasyJob.AppMVC.Controllers
{
    [ApiController]
    [Route("Job")]
    public class JobController : Controller
    {
        [HttpGet]
        [Route("list-all")]
        public async Task<ActionResult> GetAll([FromServices] IJobRepository jobRepository,
                                               [FromServices] IMapper mapper)
        {
            return View(mapper.Map<IEnumerable<JobViewModel>>(await jobRepository.GetJobsAddressUsers()));
        }

        [HttpGet]
        [Route("job-user/{id:guid}")]
        public async Task<ActionResult> GetAllById(Guid id,
                                             [FromServices] IJobRepository jobRepository,
                                             [FromServices] IMapper mapper)
        {
            return View(mapper.Map<IEnumerable<JobViewModel>>(await jobRepository.GetJobsById(id)));
        }


        [HttpGet]
        [Route("details/{id:guid}")]
        public async Task<ActionResult> Details(Guid id,
                                                [FromServices] IJobRepository jobRepository,
                                                [FromServices] IMapper mapper)
        {
            var jobViewModel = mapper.Map<JobViewModel>(await jobRepository.GetJobAdressSector(id));

            if (jobViewModel == null)
            {
                return BadRequest();
            }

            return View(jobViewModel);
        }

        [HttpGet]
        [Route("new")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("new")]
        // TODO [ValidateAntiForgeryToken]  e colocar nas outras controllers
        public async Task<ActionResult> Create([FromForm] JobViewModel jobViewModel,
                                               [FromServices] IJobService jobService,
                                               [FromServices] IUserRepository userRepository,
                                               [FromServices] IHttpContextAccessor httpContextAccessor,
                                               [FromServices] IMapper mapper)
        {

            if (!ModelState.IsValid) return BadRequest();
            
                jobViewModel.UserId = new Guid(httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));
                jobViewModel.Adress.JobId = jobViewModel.Id;
                jobViewModel.Active = true;
                
                jobViewModel.WeeklySalary = jobViewModel.HourPerWeek * jobViewModel.MinSalaryPerHour;
                jobViewModel.BiWeeklySalary = jobViewModel.WeeklySalary * 2;
                jobViewModel.MonthlySalary = jobViewModel.WeeklySalary * 4;

                await jobService.Add(mapper.Map<Job>(jobViewModel));

                return RedirectToAction("GetAll");
            
        }

        [Route("update/{id:guid}")]
        [HttpGet]
        public async Task<ActionResult> Edit(Guid id,
                                               [FromServices] IJobRepository jobRepository,
                                               [FromServices] IMapper mapper)
        {

            var jobViewModel = mapper.Map<JobViewModel>(await jobRepository.GetJobAddress(id));


            if (jobViewModel == null) return NotFound();


            return View(jobViewModel);
        }

        [Route("update/{id:guid}")]
        [HttpPost]
        // [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Guid id,
                                               [FromForm] JobViewModel jobViewModel,
                                               [FromServices] IJobRepository jobRepository,
                                               [FromServices] IJobService jobService,
                                               [FromServices] IAddressService addressService)
        {
            var job = await jobRepository.GetJobAddressUser(id);


            if (job == null) return NotFound();

            if (!ModelState.IsValid) return BadRequest(jobViewModel);

            job.Title = jobViewModel.Title;
            job.MinSalaryPerHour = jobViewModel.MinSalaryPerHour;
            job.MaxSalaryPerHour = jobViewModel.MaxSalaryPerHour;
            job.HourPerWeek = jobViewModel.HourPerWeek;

            job.WeeklySalary = jobViewModel.HourPerWeek * jobViewModel.MinSalaryPerHour;
            job.BiWeeklySalary = job.WeeklySalary * 2;
            job.MonthlySalary = job.WeeklySalary * 4;

            job.Adress.City = jobViewModel.Adress.City;
            job.Adress.State = jobViewModel.Adress.State;
            job.Adress.Country = jobViewModel.Adress.Country;

            job.BiWeeklySalaryPayment = jobViewModel.BiWeeklySalaryPayment;
            job.MonthlyPayment = jobViewModel.MonthlyPayment;
            job.WeeklySalaryPayment = jobViewModel.WeeklySalaryPayment;

            job.NeedCar = jobViewModel.NeedCar;
            job.NeedExp = jobViewModel.NeedExp;
            job.NeedTools = jobViewModel.NeedTools;
            job.Ride = jobViewModel.Ride;

            await jobService.Update(job);
            await addressService.Update(job.Adress);

            return RedirectToAction("GetAll");
        }

        [HttpGet]
        [Route("delete/{id:guid}")]
        public async Task<ActionResult> Delete(Guid id,
                                                [FromServices] IJobRepository jobRepository,
                                                [FromServices] IMapper mapper)
        {
            var jobViewModel = mapper.Map<JobViewModel>(await jobRepository.GetById(id));



            if (jobViewModel == null)
            {
                return NotFound();
            }

            return View(jobViewModel);

        }

        [HttpPost]
        [Route("delete/{id:guid}")]
        [ActionName("delete")]
        // [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(Guid id,
                                                        [FromServices] IJobService jobService,
                                                        [FromServices] IJobRepository jobRepository)
        {

            var job = await jobRepository.GetJobById(id);

            if (job == null) return NotFound();

            job.Active = false;
            await jobService.Update(job);

            return RedirectToAction("GetAll");
        }

    }
}
