using LandPApi.Dto;
using LandPApi.View;

namespace LandPApi.IService
{
    public interface ICaculateOrderService
    {
        Task<CaculateOrder> GetFeeAsync(string customerId, OrderView orderView);
    }
}
