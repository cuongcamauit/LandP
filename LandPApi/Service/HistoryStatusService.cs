using LandPApi.Base;
using LandPApi.Data;
using LandPApi.IService;
using LandPApi.Models;

namespace LandPApi.Service
{
    public class HistoryStatusService : BaseRepository<HistoryStatus>, IHistoryStatusService
    {
        public HistoryStatusService(ApplicationDbContext context) : base(context)
        {
        }
    }
}
