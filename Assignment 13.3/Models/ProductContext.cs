using Microsoft.EntityFrameworkCore;

namespace Assignment_13._3.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext
            (DbContextOptions<ProductContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<PartsCategory> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PartsCategory>().HasData(
                new PartsCategory { CategoryId = 1, CategoryName = "Hardware" },
                new PartsCategory { CategoryId = 2, CategoryName = "Components" },
                new PartsCategory { CategoryId = 3, CategoryName = "Software" },
                new PartsCategory { CategoryId = 4, CategoryName = "Accessories" }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1001, Category = Category.Components, Name = "K95 RGB Gaming Keyboard", Description = "K95 RGB PLATINUM XT Mechanical Gaming Keyboard — CHERRY® MX SPEED (NA Layout)", Price = 199.99M, ImageName = "keyboard.png", Condition = Condition.New },
                new Product { Id = 1002, Category = Category.Components, Name = "Razer Deathadder Gaming Mouse", Description = "Razer DeathAdder Elite Gaming Mouse: 16,000 DPI Optical Sensor - Chroma RGB Lighting - 7 Programmable Buttons - Mechanical Switches - Rubber Side Grips - Matte Black", Price = 69.99M, ImageName = "mouse.png", Condition = Condition.New },
                new Product { Id = 1003, Category = Category.Components, Name = "Predator Gaming Monitor", Description = "27\" Predator XB1 Gaming Monitor - XB271HU Bmiprz", Price = 399.99M, ImageName = "monitor.png", Condition = Condition.Refurbished }
                );
        }
    }


}
