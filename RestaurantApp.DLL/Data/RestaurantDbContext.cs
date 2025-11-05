using Microsoft.EntityFrameworkCore;
using RestaurantApp.Core.Models;

namespace RestaurantApp.DLL.Data
{
    public class RestaurantDbContext : DbContext
    {
        public DbSet<MenuItem> MenuItems { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.(localdb)\\mssqllocaldb;Database=RestaurantDb;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Order> orders { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.(localdb)\\mssqllocaldb;Database=RestaurantDb;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }


    }
}
