using System.Collections.Generic;
namespace Assignment_12._3.Models
{
    public interface IProductRepository
    {
        List<Product> Products { get; set; }
        List<Product> InitializeData();
        Product GetProduct(int? id);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int? id);
    }
}
