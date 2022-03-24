using Assignment_11._4.Models;
using System.Collections.Generic;
namespace Assignment_11._4.Services
{
    public class ProductData : IData
    {
        void IData.AddProduct(Product product)
        {
            throw new System.NotImplementedException();
        }

        void IData.DeleteProduct(int id)
        {
            throw new System.NotImplementedException();
        }

        IEnumerable<Product> IData.GetAll()
        {
            // throw new System.NotImplementedException();
            return null;
        }

        Product IData.GetById(int id)
        {
            // throw new System.NotImplementedException();
            return null;
        }

        void IData.UpdateProduct(Product product)
        {
            throw new System.NotImplementedException();
        }
    }
}
