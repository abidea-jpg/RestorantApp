namespace RestaurantApp.Core.Models
{
    public class Order
    {
        public int Id { get; set; } 
        public string OrderItems { get; set; }
        public double TotalAmountc { get; set; }
        public DateTime Date { get; set; }
    }
}
