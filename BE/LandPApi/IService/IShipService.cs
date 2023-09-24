using LandPApi.View;

namespace LandPApi.IService
{
    public interface IShipService
    {
        public double GetFee(OrderView orderView);
    }
}
