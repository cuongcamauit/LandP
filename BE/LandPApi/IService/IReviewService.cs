
using LandPApi.Models;
using LandPApi.View;

namespace LandPApi.IService
{
    public interface IReviewService
    {
        object Create(string customerId, ReviewView review);
        object GetAll(Guid productId, int page, int pageSize);
    }
}
