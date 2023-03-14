using Microsoft.AspNetCore.Mvc;
using LandPApi.Models;
using LandPApi.IService;
using System.Net.WebSockets;
using LandPApi.Dto;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

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

        // GET: api/Addresses
        [HttpGet]
        [Authorize(Roles = "User")]
        public async Task<IActionResult> GetAddresses()
        {
            var result = await _addressService.GetUserAddressesAsync(User.FindFirstValue(ClaimTypes.NameIdentifier));
            return Ok(new Response
            {
                Success = true,
                Data = result
            });
        }

        // GET: api/Addresses/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAddress(Guid id)
        {
            var address = await _addressService.GetByIdAsync(id, o => o.Customer!);

            if (address == null)
            {
                return NotFound();
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
        public async Task<IActionResult> PutAddress(Guid id, Address address)
        {
            if (id != address.Id)
            {
                return BadRequest();
            }
            await _addressService.UpdateAsync(address, User.FindFirstValue(ClaimTypes.NameIdentifier));
            return NoContent();
        }

        // POST: api/Addresses
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Authorize(Roles = "User")]
        public async Task<IActionResult> PostAddress(Address address)
        {
            address.CustomerId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            await _addressService.AddAsync(address);
            return CreatedAtAction("GetAddress", new { id = address.Id }, address);
        }

        // DELETE: api/Addresses/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "User")]
        public async Task<IActionResult> DeleteAddress(Guid id)
        {
            await _addressService.DeleteAsync(id, User.FindFirstValue(ClaimTypes.NameIdentifier));
            return NoContent();
        }
    }
}
