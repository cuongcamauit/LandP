using LandPApi.Dto;
using LandPApi.Models;
using LandPApi.Service;
using LandPApi.View;
using System.Security.Claims;

namespace LandPApi.IService
{
    public interface IOrderService
    {
        Task<double> GetTotal(string customerId, OrderView view);
        Task<OrderDto?> Add(string customerId, OrderView view);
        Task<List<OrderDto>> GetAll(string customerId);
        Task<OrderDto> GetById(string v, Guid id);
        void isPaid(Guid orderId);
        string PaypalCheckout(Guid orderId);
        void Update(ClaimsPrincipal user, Guid orderId, Status status, bool isPaid);
        string VNPayCheckOut(Guid orderId);
        bool checkSum(long vnp_Amount, string vnp_BankCode, string vnp_BankTranNo, string vnp_CardType, string vnp_OrderInfo, string vnp_PayDate, string vnp_ResponseCode, string vnp_TmnCode, int vnp_TransactionNo, string vnp_TransactionStatus, string vnp_TxnRef, string vnp_SecureHash);
        Guid confirm(string paymentid);
    }
}
