using System.Collections.Generic;
namespace Assignment_12._1.Models
{
    public class ProductDetails : IProductRepository
    {
        public List<Product> Products { get; set; }

        public Product GetProduct(int? id)
        {
            if (id == null)
            {
                return null;
            }
            else
            {
                return Products.Find(x => x.Id == id);
            }
        }

        public List<Product> InitializeData()
        {
            Products = new List<Product>()
            {
                new Product()
                {
                    Id = 1001,
                    Name = "Keyboard",
                    Description = "K95 RGB PLATINUM XT Mechanical Gaming Keyboard — CHERRY® MX SPEED (NA Layout)",
                    Price = "$199.99",
                    ImageName = "keyboard.png"
                },

                new Product()
                {
                    Id = 1002,
                    Name = "Mouse",
                    Description = "Razer DeathAdder Elite Gaming Mouse: 16,000 DPI Optical Sensor - Chroma RGB Lighting - 7 Programmable Buttons - Mechanical Switches - Rubber Side Grips - Matte Black",
                    Price = "$69.99",
                    ImageName = "mouse.jpg"
                },

                new Product()
                {
                    Id = 1003,
                    Name = "Monitor",
                    Description = "27\" Predator XB1 Gaming Monitor - XB271HU Bmiprz",
                    Price = "$499.99",
                    ImageName = "monitor.png"
                },

                new Product()
                {
                    Id = 1004,
                    Name = "GPU",
                    Description = "NVIDIA GeForce RTX 3080 10GB GDDR6X PCI Express 4.0 Graphics Card - Titanium and Black",
                    Price = "$699.99",
                    ImageName = "GPU.jpg"
                },

                new Product()
                {
                    Id = 1005,
                    Name = "CPU",
                    Description = "AMD Ryzen 9 5950X 16-core, 32-Thread Unlocked Desktop Processor",
                    Price = "$589.99",
                    ImageName = "CPU.jpg"
                },
            };
            return Products;
        }
    }
}
