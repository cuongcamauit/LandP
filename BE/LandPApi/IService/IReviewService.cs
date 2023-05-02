
using LandPApi.Dto;
using LandPApi.Models;
using LandPApi.View;

namespace LandPApi.IService
{
    public interface IReviewService
    {
        bool Check(string v, Guid orderId, Guid productId);
        Response Create(string customerId, ReviewView review);
        Response GetAll(Guid productId, int page, int pageSize);
    }
}
