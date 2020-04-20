using Microsoft.EntityFrameworkCore;

namespace BasicShop.Models
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext(DbContextOptions<ShopDbContext> options)
            : base(options)
        {

        }

        public DbSet<Item> Shoes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>().HasData(new Item { Id = 1, Name = "Running shoes", Description = "Nike running shoes for every day sport", Price = 1000, QuantityOfStock = 5 });
            modelBuilder.Entity<Item>().HasData(new Item { Id = 2, Name = "Printer", Description = "Some HP printer that will print pages", Price = 3000, QuantityOfStock = 2 });
            modelBuilder.Entity<Item>().HasData(new Item { Id = 3, Name = "Coca-cola", Description = "0,5 standart coke", Price = 25, QuantityOfStock = 0 });
            modelBuilder.Entity<Item>().HasData(new Item { Id = 4, Name = "Wokin", Description = "Chicken with fried rice and wokin", Price = 119, QuantityOfStock = 100 });
            modelBuilder.Entity<Item>().HasData(new Item { Id = 5, Name = "T-shirt", Description = "Blue with a corgi on bike", Price = 300, QuantityOfStock = 1 });
        }
    }
}
