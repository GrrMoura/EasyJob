using AutoMapper;
using EasyJob.AppMVC.ViewModel;
using EasyJob_Business.Models.Addresses.Services;
using EasyJob_Business.Models.Users;
using EasyJob_Business.Models.Users.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace EasyJob.AppMVC.Controllers

{
    [ApiController]
    [Route("user")]
    public class UserController : Controller
    {
        [HttpGet]
        [Route("list-all")]
        public async Task<ActionResult> GetAll([FromServices] IUserRepository userRepository,
                                               [FromServices] IMapper mapper)
        {
            var userview = mapper.Map<IEnumerable<UserViewModel>>(await userRepository.GetUsersAddress());
            return View(userview);
        }

        [HttpGet]
        [Route("list-user/{id:guid}")]
        public async Task<ActionResult> GetAllById(Guid id,
                                             [FromServices] IUserRepository userRepository,
                                             [FromServices] IMapper mapper)
        {
            return View(mapper.Map<IEnumerable<UserViewModel>>(await userRepository.GetUsersJobsById(id)));
        }

        [HttpGet]
        [Route("details/{id:guid}")]
        public async Task<ActionResult> Details(Guid id,
                                                [FromServices] IUserRepository userRepository,
                                                [FromServices] IMapper mapper)
        {
            var userViewModel = mapper.Map<UserViewModel>(await userRepository.GetUserAddress(id));



            if (userViewModel == null)
            {
                return NotFound();
            }


            return View(userViewModel);
        }

        [HttpGet]
        [Route("new")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("new")]
        //  [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([FromForm] UserViewModel userViewModel,
                                               [FromServices] IUserService userService,
                                               [FromServices] IHttpContextAccessor httpContextAccessor,
                                               [FromServices] IMapper mapper)
        {

            if (ModelState.IsValid)
            {
                userViewModel.Active = true;
                userViewModel.Id= new Guid(httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));
                userViewModel.Email= httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Email);
                userViewModel.Address.UserId = userViewModel.Id;
                await userService.Add(mapper.Map<User>(userViewModel));
                return RedirectToAction("GetAll");

            }
            return View(ModelState);
        }


        [Route("update/{id:guid}")]
        [HttpGet]
        public async Task<ActionResult> Edit(Guid id,
                                               [FromServices] IUserRepository userRepository,
                                               [FromServices] IMapper mapper)
        {

            var userViewModel = mapper.Map<UserViewModel>(await userRepository.GetUserAddress(id));



            if (userViewModel == null) return NotFound();


            return View(userViewModel);
        }

        [Route("update/{id:guid}")]
        [HttpPost]
        // [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Guid id,
                                               [FromForm] UserViewModel userViewModel,
                                               [FromServices] IUserRepository userRepository,
                                               [FromServices] IUserService userService,
                                               [FromServices] IAddressService addressService,
                                               [FromServices] IHttpContextAccessor httpContextAccessor)
        //TODO  consertar esse if
        {

            var user = await userRepository.GetUserAddress(id);

            if (user == null) return NotFound();

            if (id != user.Id) return NotFound();

            if (!ModelState.IsValid) return BadRequest(userViewModel);


            user.Name = userViewModel.Name;
            user.Email = user.Email; //httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Email);
            user.ContactPhone = userViewModel.ContactPhone;
            user.Call = userViewModel.Call;
            user.Message = userViewModel.Message;
           



            if (user.Address != null)
            {
                user.Address.City = userViewModel.Address.City;
                user.Address.State = userViewModel.Address.State;
                user.Address.Country = userViewModel.Address.Country;

                await addressService.Update(user.Address);
            }

            await userService.Update(user);


            return RedirectToAction("GetAll");
        }

        [HttpGet]
        [Route("delete/{id:guid}")]
        public async Task<ActionResult> Delete(Guid id,
                                                [FromServices] IUserRepository userRepository,
                                                [FromServices] IMapper mapper)
        {

            var userViewModel = mapper.Map<UserViewModel>(await userRepository.GetUserAddress(id));

            if (userViewModel == null)
            {
                return NotFound();
            }

            return View(userViewModel);
        }

        [HttpPost, ActionName("Delete")]
        [Route("Delete/{id:guid}")]

        // [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(Guid id,
                                                        [FromServices] IUserService userService,
                                                        [FromServices] IUserRepository userRepository)
        {

            var user = await userRepository.GetUserAddressJob(id);//TODO: testar depois se posso remover só pelo id e excluir essa ida ao banco de dados


            if (user == null)
            {
                return NotFound();
            }

            user.Active = false;

            await userService.Update(user);
            return RedirectToAction("GetAll");
        }
    }
}
