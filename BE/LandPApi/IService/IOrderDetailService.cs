using LandPApi.Dto;
using LandPApi.Models;

namespace LandPApi.IService
{
    public interface IOrderDetailService
    {
        List<OrderDetailDto> GetAll(Guid orderId);
    }
}
