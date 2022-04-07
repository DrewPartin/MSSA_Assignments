using System.Collections.Generic;

namespace Assignment_13._3.Models
{
    public class ProductDetails : IProductRepository
    {
        public List<Product> Products { get; set; }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void DeleteProduct(int? id)
        {
            var prd = Products.Find(x => x.Id == id);
            Products.Remove(prd);
        }

        public ProductDetails()
        {
            Products = new List<Product>()
            {
                new Product()
                {
                    Id = 1001,
                    Category = Category.Components,
                    Name = "K95 RGB Gaming Keyboard",
                    Description = "K95 RGB PLATINUM XT Mechanical Gaming Keyboard — CHERRY® MX SPEED (NA Layout)",
                    Price = 199.99M,
                    ImageName = "keyboard.png",
                    Condition = Condition.New
                },

                new Product()
                {
                    Id = 1002,
                    Category = Category.Components,
                    Name = "Razer Deathadder Gaming Mouse",
                    Description = "Razer DeathAdder Elite Gaming Mouse: 16,000 DPI Optical Sensor - Chroma RGB Lighting - 7 Programmable Buttons - Mechanical Switches - Rubber Side Grips - Matte Black",
                    Price = 69.99M,
                    ImageName = "mouse.png",
                    Condition = Condition.New
                },

                new Product()
                {
                    Id = 1003,
                    Category = Category.Components,
                    Name = "Predator Gaming Monitor",
                    Description = "27\" Predator XB1 Gaming Monitor - XB271HU Bmiprz",
                    Price = 399.99M,
                    ImageName = "monitor.png",
                    Condition = Condition.Refurbished
                },

                new Product()
                {
                    Id = 1004,
                    Category = Category.Hardware,
                    Name = "NVIDIA GeForce RTX 3080 GPU",
                    Description = "NVIDIA GeForce RTX 3080 10GB GDDR6X PCI Express 4.0 Graphics Card - Titanium and Black",
                    Price = 629.99M,
                    ImageName = "GPU.png",
                    Condition = Condition.Used
                },

                new Product()
                {
                    Id = 1005,
                    Category = Category.Hardware,
                    Name = "AMD Ryzen 9 CPU",
                    Description = "AMD Ryzen 9 5950X 16-core, 32-Thread Unlocked Desktop Processor",
                    Price = 589.99M,
                    ImageName = "CPU.png",
                    Condition = Condition.New
                },
            };
        }

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

        public IEnumerable<Product> InitializeData()
        {
            return Products;
        }

        public void UpdateProduct(Product product)
        {
            var prd = Products.Find(x => x.Id == product.Id);
            if (prd != null)
            {
                prd.Id = product.Id;
                prd.Category = product.Category;
                prd.Name = product.Name;
                prd.Description = product.Description;
                prd.Price = product.Price;
                prd.ImageName = product.ImageName;
                prd.Condition = product.Condition;
            }
        }
    }
}
