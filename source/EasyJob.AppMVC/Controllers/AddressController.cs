using AutoMapper;
using EasyJob.AppMVC.ViewModel;
using EasyJob_Business.Models.Addresses;
using EasyJob_Business.Models.Addresses.Services;
using EasyJob_Business.Models.Users;
using EasyJob_Business.Models.Users.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace EasyJob.AppMVC.Controllers

{
    [ApiController]
    [Route("address")]
    public class AddressController : Controller
    {


        [Route("update/{id:guid}")]
        [HttpGet]
        public async Task<ActionResult> Update(Guid id,
                                               [FromServices] IAddressRepository addressRepository,
                                               [FromServices] IMapper _mapper)
        {
            
            var addressViewModel = _mapper.Map<AddressViewModel>(await addressRepository.GetUserAddress(id));


            if (addressViewModel == null)
            {
                return NotFound();
            }


            return View();
        }

        [Route("Update/{id:guid}")]
        [HttpPost]
        // [ValidateAntiForgeryToken]
        public async Task<ActionResult> Update(Guid id,
                                               [FromForm] AddressViewModel addressViewModel,
                                               [FromServices] IAddressService addressService,
                                               [FromServices] IMapper mapper)

        {
            
            if (!ModelState.IsValid) return BadRequest(addressViewModel);


            await addressService.Update(mapper.Map<Adress>(addressViewModel));

            return RedirectToAction("GetAll", "User");
        }

        [HttpGet]
        [Route("delete/{id:guid}")]
        public async Task<ActionResult> Delete(Guid id,
                                                [FromServices] IUserRepository userRepository,
                                                [FromServices] IMapper mapper)
        {
            var employerViewModel = mapper.Map<UserViewModel>(await userRepository.GetUserAddress(id));


            if (employerViewModel == null)
            {
                return NotFound();
            }

            return Ok(employerViewModel);

        }

        [HttpDelete]
        [Route("delete/{id:guid}")]
        [ActionName("delete")]
        // [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(Guid id,
                                                        [FromServices] IUserService userService,
                                                        [FromServices] IUserRepository userRepository,
                                                        [FromServices] IMapper mapper)
        {

            var employerViewModel = mapper.Map<UserViewModel>(await userRepository.GetUserAddress(id));

            if (employerViewModel == null)
            {
                return NotFound();
            }
            await userService.Remove(id);
            return RedirectToAction("GetAll");
        }
    }
}
