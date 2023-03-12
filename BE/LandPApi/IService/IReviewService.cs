using LandPApi.Base;
using LandPApi.Models;

namespace LandPApi.IService
{
    public interface IReviewService
    {
        Task AddAsync(Review review);   
    }
}
