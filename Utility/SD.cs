

using YumBlazor.Data;

namespace YumBlazor.Utility
{
    public static class SD
    {
        public static string Role_Admin = "Admin";
        public static string Role_Customer ="Müşteri";

        public static string StatusPending = "Hazırlanıyor";
        public static string StatusApproved = "Onaylandı";
        public static string StatusReadyForPickup = "Teslim İçin Hazır";
        public static string StatusCompleted = "Tamamlandı";
        public static string StatusCancelled = "İptal Et";

        public static List<OrderDetail> ConvertShoppingCartListToOrderDetail(List<ShoppingCart> shoppingCarts)
        {
            List<OrderDetail> orderDetails = new List<OrderDetail>();
            foreach(var cart in shoppingCarts)
            {
                OrderDetail orderDetail = new OrderDetail()
                {
                    ProductId = cart.ProductId,
                    Count = cart.Count,
                    Price = Convert.ToDouble(cart.Product.Price),
                    ProductName = cart.Product.Name
                };
                orderDetails.Add(orderDetail);
            }
            return orderDetails;
        }
    }
}
