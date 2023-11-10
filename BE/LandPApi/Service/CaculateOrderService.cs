using LandPApi.Dto;
using LandPApi.IService;
using LandPApi.Models;
using LandPApi.Repository;
using LandPApi.View;

namespace LandPApi.Service
{
    public class CaculateOrderService : ICaculateOrderService
    {
        private readonly IOrderService _orderService;
        private readonly IRepository<Address> _repoAddress;

        public CaculateOrderService(IOrderService orderService, IRepository<Address> repository)
        {
            _orderService = orderService;
            _repoAddress = repository;
        }
        public async Task<CaculateOrder?> GetFeeAsync(string customerId, OrderView orderView)
        {
            var valueOrder = await _orderService.GetTotal(customerId, orderView);
            var address = _repoAddress.ReadByCondition(o => o.CustomerId == customerId && o.Id == orderView.AddressId).FirstOrDefault();
            if (address == null)
            {
                return null;
            }
            var postData = new PostData();
            postData.to_ward_code = address.WardCode!;
            postData.to_district_id = address.DistrictId;
            postData.insurance_value = Convert.ToInt32(valueOrder);
            var shipfee = await GHN.FeeShip(postData);
            return new CaculateOrder
            {
                SubTotal = valueOrder,
                Ship = shipfee,
                Total = shipfee + valueOrder
            };
        }
    }
}
