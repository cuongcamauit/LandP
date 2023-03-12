using Microsoft.AspNetCore.Mvc;
using LandPApi.Models;
using LandPApi.IService;

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
        public async Task<IActionResult> GetAddresses()
        {
            return Ok(await _addressService.GetAllAsync(o => o.Customer!));
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

            return Ok(address);
        }

        // PUT: api/Addresses/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAddress(Guid id, Address address)
        {
            if (id != address.Id)
            {
                return BadRequest();
            }

            return Ok(await _addressService.UpdateAsync(address));
        }

        // POST: api/Addresses
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<IActionResult> PostAddress(Address address)
        {
            return CreatedAtAction("GetAddress", await _addressService.AddAsync(address));
        }

        // DELETE: api/Addresses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAddress(Guid id)
        {
            return Ok(await _addressService.DeleteAsync(id));
        }
    }
}
