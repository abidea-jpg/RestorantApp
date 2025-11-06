namespace RestaurantApp.PL;

internal class Program
{
    static void Main(string[] args)
    {
        var food1 = new MenuItem { Id = 1, Name = "Dolma", Price = 8, Category = "Ana Yemek" };
        var drink1 = new MenuItem { Id = 2, Name = "Ayran", Price = 5, Category = "İçki" };

        var order = new Order 
        { Id = 1001,
            Date = DateTime.Now,
            OrdersItems = new List<OrderItem>()
        };

        order.OrderItems.Add(new OrderItem { MenuItem = food1, Count = 2 });
        order.OrderItems.Add(new OrderItem { MenuItem = drink1, Count = 3 });

        Console.WriteLine($"Sifariş №{order.Id} | Tarix: {order.Date}");
        Console.WriteLine($"Ümumi məbləğ: {order.TotalAmount} AZN");

    }
}
