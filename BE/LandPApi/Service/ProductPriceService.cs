using AutoMapper;
using LandPApi.Dto;
using LandPApi.IService;
using LandPApi.Models;
using LandPApi.Repository;
using LandPApi.View;

namespace LandPApi.Service
{
    public class ProductPriceService : IProductPriceService
    {
        private IRepository<ProductPrice> _repository;
        private readonly IMapper _mapper;

        public ProductPriceService(IRepository<ProductPrice> repository,
                                    IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public List<ProductPriceDto> GetProductPriceList(Guid id)
        {
            var listProductPrics = _repository.ReadByCondition(o => o.ProductId == id);
            return _mapper.Map<List<ProductPriceDto>>(listProductPrics);
        }

        public ProductPriceDto Create(ProductPriceView productPriceView)
        {
            var productPrice = _mapper.Map<ProductPrice>(productPriceView);
            _repository.Create(productPrice);
            _repository.Save();
            return _mapper.Map<ProductPriceDto>(productPrice);
        }

        public bool CheckPriceExist(ProductPriceView productPriceView)
        {
            var productPrice = _repository.ReadByCondition(o => 
            (o.FromDate <= productPriceView.FromDate && o.ToDate >= productPriceView.FromDate) || 
            (o.FromDate <= productPriceView.ToDate && o.ToDate <= productPriceView.ToDate));
            return productPrice != null;
        }

        public void Delete(int id)
        {
            ProductPrice? price = _repository.ReadByCondition(o => o.Id == id).FirstOrDefault();
            if (price != null)
            {
                _repository.Delete(price);
                _repository.Save();
            }
        }
    }
}
