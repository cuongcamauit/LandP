
using AutoMapper;
using LandPApi.Data;
using LandPApi.Dto;
using LandPApi.IService;
using LandPApi.Models;
using LandPApi.Repository;

namespace LandPApi.Service
{
    public class HistoryStatusService : IHistoryStatusService
    {
        private readonly IRepository<HistoryStatus> _repository;
        private readonly IMapper _mapper;

        public HistoryStatusService(IRepository<HistoryStatus> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public List<HistoryStatusDto> GetAll(Guid orderId)
        {
            var result = _repository.ReadByCondition(o => o.OrderId== orderId).ToList();
            return _mapper.Map<List<HistoryStatusDto>>(result);
        }
    }
}
