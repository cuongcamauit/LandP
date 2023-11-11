using LandPApi.Dto;
using LandPApi.Models;
using LandPApi.View;

namespace LandPApi.IService
{
    public interface IAddressService : IGenericService<AddressView, AddressDto, Address>
    {
        Task Delete(Guid id, string customerId);
        Task<List<AddressDto>> GetAll(string customerId);
        Task SetDefault(Guid id, string customerId);
        bool HaveNoAddress(string customerId);
    }
}
