using AutoMapper;
using LandPApi.Data;
using LandPApi.Dto;
using LandPApi.IService;
using LandPApi.Models;
using LandPApi.Repository;

namespace LandPApi.Service
{
    public class OrderDetailService : IOrderDetailService
    {
        private readonly IRepository<OrderDetail> _repository;
        private readonly IMapper _mapper;

        public OrderDetailService(IRepository<OrderDetail> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public List<OrderDetailDto> GetAll(Guid orderId)
        {
            var result = _repository.ReadByCondition(o => o.OrderId == orderId);
            return _mapper.Map<List<OrderDetailDto>>(result);
        }
    }
}
