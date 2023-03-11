using LandPApi.Base;
using LandPApi.Data;
using LandPApi.IService;
using LandPApi.Models;

namespace LandPApi.Service
{
    public class AddressService : BaseRepository<Address>, IAddressService
    {
        public AddressService(ApplicationDbContext context) : base(context)
        {
        }
    }
}
