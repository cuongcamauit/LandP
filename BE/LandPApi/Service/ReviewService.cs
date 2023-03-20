using AutoMapper;
using LandPApi.Dto;
using LandPApi.IService;
using LandPApi.Models;
using LandPApi.Repository;
using LandPApi.View;
using Microsoft.EntityFrameworkCore;

namespace LandPApi.Service
{
    public class ReviewService : IReviewService
    {
        private readonly IRepository<Review> _repoReview;
        private readonly IRepository<Product> _repoPro;
        private readonly IMapper _mapper;

        public ReviewService(IRepository<Review> repoReview, IRepository<Product> repoPro, IMapper mapper)
        {
            _repoReview = repoReview;
            _repoPro = repoPro;
            _mapper = mapper;
        }

        public object Create(string customerId, ReviewView review)
        {
            var check = _repoReview.ReadByCondition(o => o.CustomerId == customerId 
                                                    && o.OrderId == review.OrderId
                                                    && o.ProductId == review.ProductId).FirstOrDefault();
            if (check == null)
            {
                return false;
            }

            _repoReview.Create(new Review
            {
                CustomerId = customerId,
                ProductId = review.ProductId,
                OrderId = review.OrderId,
                Comment = review.Comment,
                Rating = review.Rating
            });
            _repoReview.Save();

            // update average rating
            var created = _repoPro.ReadByCondition(o => o.Id == review.ProductId).FirstOrDefault();
            var productsReviews = _repoReview.ReadByCondition(o => o.ProductId == created!.Id);
            created!.ReviewQuantity += 1;
            created!.AverageRating = productsReviews.Sum(o => o.Rating);
            _repoPro.Update(created);
            _repoPro.Save();
            return true;
        }

        public object GetAll(Guid productId, int page, int pageSize)
        {
            var reviews = _repoReview.ReadByCondition(o => o.ProductId == productId).Include(review => review.Customer);
            #region Paginate
            var result = PaginatedList<Review>.Create(reviews, page, pageSize);
            #endregion

            return new
            {
                Success = true,
                Data =
                new
                {
                    reviews = _mapper.Map<List<ReviewDto>>(result),
                    pagination = new
                    {
                        currentPage = result.PageIndex,
                        totalPage = result.TotalPage,
                        pageSize = pageSize,
                        totalItem = result.TotalItem
                    }
                }
            };
        }
    }
}
