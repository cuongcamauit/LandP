using LandPApi.Dto;
using LandPApi.Models;

namespace LandPApi.IService
{
    public interface IOrderDetailService
    {
        object GetAll(Guid orderId);
    }
}
