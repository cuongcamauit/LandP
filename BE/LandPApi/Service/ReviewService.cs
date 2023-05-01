using AutoMapper;
using LandPApi.Dto;
using LandPApi.IService;
using LandPApi.Models;
using LandPApi.Repository;
using LandPApi.View;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LandPApi.Service
{
    public class ReviewService : IReviewService
    {
        private readonly IRepository<Review> _repoReview;
        private readonly IRepository<OrderDetail> _repoDetail;
        private readonly IRepository<Product> _repoPro;
        private readonly IMapper _mapper;
        private readonly UserManager<Customer> _userManager;

        public ReviewService(IRepository<Review> repoReview
                            , IRepository<Product> repoPro
                            , IRepository<OrderDetail> repoDetail
                            , IMapper mapper
                            , UserManager<Customer> userManager)
        {
            _repoReview = repoReview;
            _repoDetail = repoDetail;
            _repoPro = repoPro;
            _mapper = mapper;
            _userManager = userManager;
        }

        public Response Create(string customerId, ReviewView review)
        {
            var check = _repoReview.ReadByCondition(o => o.CustomerId == customerId 
                                                    && o.OrderId == review.OrderId
                                                    && o.ProductId == review.ProductId).FirstOrDefault();
            var haveOrder = _repoDetail.ReadByCondition(o => o.OrderId == review.OrderId && o.ProductId == review.ProductId && o.Order!.CustomerId == customerId).FirstOrDefault();

            if (haveOrder == null)
            {
                return new Response
                {
                    Success = false,
                    StatusCode = 404,
                    Message = "Doesn't have order",
                };
            }

            if (check != null)
            {
                return new Response
                {
                    Success = false,
                    StatusCode = 409,
                    Message = "You reviewed this product",
                    
                };
            }


            _repoReview.Create(new Review
            {
                CustomerId = customerId,
                ProductId = review.ProductId,
                OrderId = review.OrderId,
                Comment = review.Comment,
                Rating = review.Rating,
                Name = _userManager.FindByIdAsync(customerId).Result.Name
            });
            _repoReview.Save();

            // update average rating
            var created = _repoPro.ReadByCondition(o => o.Id == review.ProductId).FirstOrDefault();
            var productsReviews = _repoReview.ReadByCondition(o => o.ProductId == created!.Id);
            created!.ReviewQuantity += 1;
            created!.AverageRating = productsReviews.Sum(o => o.Rating);
            _repoPro.Update(created);
            _repoPro.Save();
            return new Response 
            { 
                StatusCode = 201,
                Message = "Created review successful!"
            };
        }

        public Response GetAll(Guid productId, int page, int pageSize)
        {
            var reviews = _repoReview.ReadByCondition(o => o.ProductId == productId).Include(review => review.Customer);
            #region Paginate
            var result = PaginatedList<Review>.Create(reviews, page, pageSize);
            #endregion

            return new Response
            {
                StatusCode = 200,
                Message = "Get all reviews",
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
