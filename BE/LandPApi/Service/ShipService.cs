using LandPApi.IService;
using LandPApi.View;

namespace LandPApi.Service
{
    public class ShipService : IShipService
    {
        public double GetFee(OrderView orderView)
        {
            return 10;
        }
    }
}
