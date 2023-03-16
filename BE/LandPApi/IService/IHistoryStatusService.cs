using LandPApi.Dto;
using LandPApi.Models;
using LandPApi.Service;

namespace LandPApi.IService
{
    public interface IHistoryStatusService
    {
        List<HistoryStatusDto> GetAll(Guid orderId);
    }
}
