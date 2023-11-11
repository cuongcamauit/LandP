
using AutoMapper;
using LandPApi.Dto;
using LandPApi.IService;
using LandPApi.Models;
using LandPApi.Repository;
using LandPApi.View;
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

        public bool HaveNoAddress(string customerId)
        {
            var check = _repository.ReadByCondition(o => o.CustomerId == customerId).Count();
            return check == 0;
        }

        public async Task SetDefault(Guid id, string customerId)
        {
            Address? address = await _repository.ReadByCondition(o => o.Id == id && o.CustomerId == customerId).FirstOrDefaultAsync();
            if (address != null)
            {
                var addresses = _repository.ReadByCondition(o => o.CustomerId == customerId && o.isDefault == true && o.Id != id);
                foreach (var item in addresses)
                {
                    item.isDefault = false;
                    _repository.Update(item);
                }
                address.isDefault = true;
                _repository.Update(address);
                _repository.Save();
            }
        }
    }
}
