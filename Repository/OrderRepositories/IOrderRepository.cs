using YumBlazor.Data;

namespace YumBlazor.Repository.OrderRepositories
{
    public interface IOrderRepository
    {
        public Task<OrderHeader> CreateOrderAsync(OrderHeader orderHeader);
        public Task<OrderHeader> GetAsync(int id);
        public Task<OrderHeader> GetOrderBySesionIdAsync(string sessionId);

        public Task<IEnumerable<OrderHeader>> GetAllAsync(string? userId = null);
        public Task<OrderHeader> UpdateStatusAsync(int orderId, string status,string paymentIntentId);
    }
}
