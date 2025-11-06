

namespace RestaurantApp.PL
{
    internal class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public object TotalAmount { get; internal set; }
        public object OrderItems { get; internal set; }
        public List<OrderItem> OrdersItems { get; internal set; }
    }
}