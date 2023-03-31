using Microsoft.AspNetCore.Mvc;
using LandPApi.Models;
using LandPApi.IService;
using System.Net.WebSockets;
using LandPApi.Dto;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using LandPApi.View;

namespace LandPApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressesController : ControllerBase
    {
        private readonly IAddressService _addressService;

        public AddressesController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        // GET: api/Addresses/
        [HttpGet]
        [Authorize(Roles = "User")]
        public async Task<IActionResult> GetAddresses()
        {
            var result = await _addressService.GetAll(User.FindFirstValue(ClaimTypes.NameIdentifier));
            return Ok(new Response
            {
                Success = true,
                Data = result
            });
        }

        // GET: api/Addresses/Admin
        [HttpGet("Admin")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetAddressesAdmin()
        {
            var result = await _addressService.GetAll();
            return Ok(new Response
            {
                Success = true,
                Data = result
            });
        }


        // GET: api/Addresses/5
        [HttpGet("{id}")]
        [Authorize(Roles = "User")]
        public async Task<IActionResult> GetAddress(Guid id)
        {
            var address = await _addressService.GetById(id);

            if (address == null)
            {
                return Ok(new Response
                {
                    StatusCode = 404,
                    Success = false,
                    Message = "Address not exists"
                });
            }

            return Ok(new Response
            {
                Success = true,
                Data = address
            });
        }

        // PUT: api/Addresses/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize(Roles = "User")]
        public IActionResult PutAddress(Guid id, AddressDto address)
        {
            if (!ModelState.IsValid)
            {
                var message = string.Join(" | ", ModelState.Values
                            .SelectMany(v => v.Errors)
                            .Select(e => e.ErrorMessage));
                return Ok(new Response
                {
                    Success = false,
                    Message = "Some properties is wrong",
                    Data = message,
                    StatusCode = 422
                });
            }
            if (id != address.Id)
            {
                return Ok(new
                {
                    Success = false,
                    Message = "Id doesn't match with id's address",
                    StatusCode = 400
                });
            }
            address.CustomerId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            _addressService.Update(address);
            return Ok(new Response
            {
                Message = "Updated successful!",
                Data = address,
                Success = true
            });
        }

        // POST: api/Addresses
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Authorize(Roles = "User")]
        public IActionResult PostAddress(AddressView address)
        {
            //if (!ModelState.IsValid)
            //{
            //    var message = string.Join(" | ", ModelState.Values
            //                .SelectMany(v => v.Errors)
            //                .Select(e => e.ErrorMessage));
            //    return Ok(new Response
            //    {
            //        Success = false,
            //        Message = "Some properties is wrong",
            //        Data = message,
            //        StatusCode = 422
            //    });
            //}
            address.CustomerId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var result = _addressService.Create(address);
            return Ok(new Response
            {
                StatusCode = 201,
                Data = result,
                Message = "Created successful!"
            });
        }


        // DELETE: api/Addresses/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "User")]
        public async Task<IActionResult> DeleteAddress(Guid id)
        {
            await _addressService.Delete(id, User.FindFirstValue(ClaimTypes.NameIdentifier));
            return Ok(new Response
            {
                Message = "Deleted successful!"
            });
        }
    }
}
