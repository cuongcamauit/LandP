using LandPApi.Base;
using LandPApi.Models;

namespace LandPApi.IService
{
    public interface IAddressService : IBaseRepository<Address>
    {
        Task<ICollection<Address>> GetUserAddressesAsync(string customerId);
        Task DeleteAsync(Guid id, string customerId);
        Task UpdateAsync(Address address, string customerId);
    }
}
