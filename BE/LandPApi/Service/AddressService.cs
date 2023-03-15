
using AutoMapper;
using LandPApi.Data;
using LandPApi.Dto;
using LandPApi.IService;
using LandPApi.Models;
using LandPApi.Repository;
using LandPApi.View;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LandPApi.Service
{
    public class AddressService : GenericService<AddressView, AddressDto, Address>, IAddressService
    {
        public AddressService(IRepository<Address> repository, IMapper mapper) : base(repository, mapper)
        {
        }

        public async Task Delete(Guid id, string customerId)
        {
            var address = await _repository.ReadByCondition(o => (o.Id == id && o.CustomerId == customerId)).FirstOrDefaultAsync();
            if (address != null)
            {
                _repository.Delete(address);
                _repository.Save();
            }
        }

        public async Task<List<AddressDto>> GetAll(string customerId)
        {
            var addresses = await _repository.ReadByCondition(o => o.CustomerId == customerId).ToListAsync();
            return _mapper.Map<List<AddressDto>>(addresses);
        }
    }
}
