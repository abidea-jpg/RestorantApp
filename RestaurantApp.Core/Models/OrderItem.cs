namespace RestaurantApp.Core.Models
{
    public class OrderItem
    {
        public MenuItem MenuItem { get; set; }
        public int Count { get; set; }
        public double GetTotalPrice()
        {
            return MenuItem.Price * Count;
        }
    }
}
