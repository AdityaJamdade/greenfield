using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using POCO;

namespace Catalog
{
    public class ProductService : IProductService
    {
        private List<Product> _products;

        public ProductService()
        {
            this._products = new List<Product>();
        }

        public bool Delete(int id)
        {
            Product theProduct= GetProduct(id);
            return this._products.Remove(theProduct);
        }

        public List<Product> GetAllProducts()
        {
            // return this._products;

            List<Product> products = new List<Product>();
            products.Add(new Product { Id = 1, Name = "gerberas", Description = "Wedding Flower", UnitPrice = 12, Quantity = 3000, ImageUrl = "/Images/gerbera.jpg" });
            products.Add(new Product { Id = 2, Name = "rose", Description = "Wedding Flower", UnitPrice = 10, Quantity = 5000, ImageUrl = "/Images/gerbera.jpg" });
            products.Add(new Product { Id = 3, Name = "lily", Description = "Wedding Flower", UnitPrice = 12, Quantity = 1000, ImageUrl = "/Images/gerbera.jpg" });
            products.Add(new Product { Id = 4, Name = "white lily", Description = "Wedding Flower", UnitPrice = 10, Quantity = 10000, ImageUrl = "/Images/gerbera.jpg" });

            return products;
        }

        public Product GetProduct(int id)
        {
            //foreach (Product theProduct in _products)
            //{
            //    if(theProduct.Id == id) return theProduct;
            //}
            //return null;

            return new Product { Id = 1, Name = "gerberas", Description = "Wedding Flower", UnitPrice = 12, Quantity = 3000, ImageUrl = "/Images/gerbera.jpg" };
        }

        public bool Insert(Product prod)
        {
            this._products.Add(prod);
            return true;
        }

        public bool Update(Product prod)
        {
            Product toRemove = GetProduct(prod.Id);
            this._products.Remove(toRemove);

            this._products.Add(prod);
            return true;
        }
    }
}
