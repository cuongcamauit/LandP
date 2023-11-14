using LandPApi.IService;
using LandPApi.Models;
using LandPApi.Repository;

namespace LandPApi.Service
{
    public class ViewService : IViewService
    {
        private readonly IRepository<Models.View> _repoView;
        private readonly IRepository<Product> _repoPro;
        private readonly ICacheService _cacheService;

        public ViewService(IRepository<Models.View> repoView, IRepository<Product> repoPro, ICacheService cacheService)
        {
            _repoView = repoView;
            _repoPro = repoPro;
            _cacheService = cacheService;
        }
        public void Create(string customerId, Guid productId)
        {
            var product = _repoPro.ReadByCondition(o => o.Id == productId).FirstOrDefault();
            var view = _repoView.ReadByCondition(o => o.ProductId == productId &&
                                                o.CustomerId == customerId).FirstOrDefault();
            if (product != null && view == null)
            {
                _repoView.Create(new Models.View
                {
                    CustomerId = customerId,
                    ProductId = productId,
                    Quantity = 1
                });
            }
            if (view != null)
            {
                view.Quantity += 1;
                _repoView.Update(view);
            }
            _repoView.Save();
            _cacheService.UpdateProduct(productId);
        }
    }
}
