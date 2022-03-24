using System.Collections.Generic;
using Assignment_11._4.Models;
namespace Assignment_11._4.Services
{
    public interface IData
    {
        IEnumerable<Product> GetAll();
        Product GetById(int id);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int id);
    }
}
