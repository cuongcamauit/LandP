using LandPApi.Base;
using LandPApi.Data;
using LandPApi.IService;
using LandPApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LandPApi.Service
{
    public class AddressService : BaseRepository<Address>, IAddressService
    {
        public AddressService(ApplicationDbContext context) : base(context)
        {
        }

        public async Task DeleteAsync(Guid id, string customerId)
        {
            var address = await _context.Addresses.FirstOrDefaultAsync(o => o.Id == id && o.CustomerId == customerId);
            if (address != null)
            {
                _context.Remove(address!);
                await _context.SaveChangesAsync();
            }
            throw new Exception("Not found");
        }

        public async Task<ICollection<Address>> GetUserAddressesAsync(string customerId)
        {
            var result = await _context.Addresses.Where(o => o.CustomerId == customerId).ToListAsync();
            return result;
        }

        public async Task UpdateAsync(Address address, string customerId)
        {
            var ad = _context.Addresses.FirstOrDefault(o => o.Id == address.Id && o.CustomerId == customerId);

            if (ad != null)
            {
                address.CustomerId = customerId;
                _context.UpdateRange(address);
                await _context.SaveChangesAsync();
            }
        }
    }
}
