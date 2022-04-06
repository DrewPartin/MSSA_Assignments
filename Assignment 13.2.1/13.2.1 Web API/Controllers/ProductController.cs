using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using _13._2._1_Web_API.Models;

namespace _13._2._1_Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private List<Product> products = new List<Product>();
        public ProductController()
        {
            products.Add(new Product { Id = 1001, Category = Category.Components, Name = "K95 RGB Gaming Keyboard", Description = "K95 RGB PLATINUM XT Mechanical Gaming Keyboard — CHERRY® MX SPEED (NA Layout)", Price = 199.99M, ImageName = "keyboard.png", Condition = Condition.New });
            products.Add(new Product { Id = 1002, Category = Category.Components, Name = "Razer Deathadder Gaming Mouse", Description = "Razer DeathAdder Elite Gaming Mouse: 16,000 DPI Optical Sensor - Chroma RGB Lighting - 7 Programmable Buttons - Mechanical Switches - Rubber Side Grips - Matte Black", Price = 69.99M, ImageName = "mouse.png", Condition = Condition.New });
            products.Add(new Product { Id = 1003, Category = Category.Components, Name = "Predator Gaming Monitor", Description = "27\" Predator XB1 Gaming Monitor - XB271HU Bmiprz", Price = 399.99M, ImageName = "monitor.png", Condition = Condition.Refurbished });
        }
        [HttpGet()]
        public List<Product> GetProducts()
        {
            return this.products;
        }

        [HttpGet("Id")]
        public ActionResult<Product>GetProductById(int id)
        {
            var product = this.products.Find(x => x.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
