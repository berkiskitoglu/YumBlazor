using Microsoft.EntityFrameworkCore;
using YumBlazor.Data;

namespace YumBlazor.Repository.OrderRepositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDbContext _db;

        public OrderRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<OrderHeader> CreateOrderAsync(OrderHeader orderHeader)
        {
            orderHeader.OrderDate = DateTime.Now;
            await _db.OrderHeaders.AddAsync(orderHeader);
            await _db.SaveChangesAsync();
            return orderHeader;
        }

        public async Task<IEnumerable<OrderHeader>> GetAllAsync(string? userId = null)
        {
            if(!string.IsNullOrEmpty(userId))
            {
                return await _db.OrderHeaders.Where(o => o.UserId == userId).ToListAsync();
            }
            return await _db.OrderHeaders.ToListAsync();
        }

        public async Task<OrderHeader> GetAsync(int id)
        {
            return await _db.OrderHeaders.Include(o => o.OrderDetails).FirstOrDefaultAsync(o => o.Id == id);
        }

        public async Task<OrderHeader> GetOrderBySesionIdAsync(string sessionId)
        {
            return await _db.OrderHeaders.FirstOrDefaultAsync(o => o.SessionId == sessionId);
            
        }

        public async Task<OrderHeader> UpdateStatusAsync(int orderId, string status, string paymentIntentId)
        {
             var orderHeader = await _db.OrderHeaders.FirstOrDefaultAsync(o => o.Id == orderId);
            if(orderHeader != null)
            {
                orderHeader.Status = status;
                if(!string.IsNullOrEmpty(paymentIntentId))
                {
                    orderHeader.PaymentIntentId = paymentIntentId;
                }
                await _db.SaveChangesAsync();
            }
            return orderHeader;
        }
    }
}
