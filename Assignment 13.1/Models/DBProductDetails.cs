using System.Collections.Generic;

namespace Assignment_13._1.Models
{
    public class DBProductDetails : IProductRepository
    {
        public List<Product> Products { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        private ProductContext _productContext;
        public DBProductDetails(ProductContext productContext)
        {
            _productContext = productContext;
        }

        public void AddProduct(Product product)
        {
            if (product.Category.ToString() == "Hardware")
            {
                product.CategoryId = 1;
            }
            if (product.Category.ToString() == "Components")
            {
                product.CategoryId = 2;
            }
            if (product.Category.ToString() == "Software")
            {
                product.CategoryId = 3;
            }
            if (product.Category.ToString() == "Accessories")
            {
                product.CategoryId = 4;
            }

            _productContext.Products.Add(product);
            _productContext.SaveChanges();
        }

        public void DeleteProduct(int? id)
        {
            var prd = _productContext.Products.Find(id);
            if (prd != null)
            {
                _productContext.Products.Remove(prd);
                _productContext.SaveChanges();
            }
        }

        public Product GetProduct(int? id)
        {
            return _productContext.Products.Find(id);
        }

        public IEnumerable<Product> InitializeData()
        {
            return _productContext.Products;
        }

        public void UpdateProduct(Product product)
        {
            Product prd = _productContext.Products.Find(product.Id);
            if (prd != null)
            {
                prd.Id = product.Id;
                prd.Name = product.Name;
                prd.Description = product.Description;
                prd.Price = product.Price;
                prd.ImageName = product.ImageName;
                prd.Condition = product.Condition;
                if (product.Category.ToString() == "Hardware")
                {
                    prd.CategoryId = 1;
                }
                if (product.Category.ToString() == "Components")
                {
                    prd.CategoryId = 2;
                }
                if (product.Category.ToString() == "Software")
                {
                    prd.CategoryId = 3;
                }
                if (product.Category.ToString() == "Accessories")
                {
                    prd.CategoryId = 4;
                }

                _productContext.SaveChanges();
            }
        }
    }
}
