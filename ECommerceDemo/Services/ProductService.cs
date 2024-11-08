using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using POCO;
using Specification;
using BinaryDataRepository;

namespace Services
{
    public class ProductService : IProductService
    {
        private List<Product> _products;

        public ProductService()
        {
            this._products = new List<Product>();
        }
        public bool Seeding()
        {
            bool status = false;
            List<Product> products = new List<Product>();
            products.Add(new Product { Id = 1, Name = "gerberas", Description = "Wedding Flower", UnitPrice = 12, Quantity = 3000, ImageUrl = "/Images/gerbera.jpg" });
            products.Add(new Product { Id = 2, Name = "rose", Description = "Wedding Flower", UnitPrice = 10, Quantity = 5000, ImageUrl = "/Images/gerbera.jpg" });
            products.Add(new Product { Id = 3, Name = "lily", Description = "Wedding Flower", UnitPrice = 12, Quantity = 1000, ImageUrl = "/Images/gerbera.jpg" });
            products.Add(new Product { Id = 4, Name = "white lily", Description = "Wedding Flower", UnitPrice = 10, Quantity = 10000, ImageUrl = "/Images/gerbera.jpg" });

            IDataRepository repo = new BinaryRepository();
            status = repo.Serialize("products.dat", products);

            return status;
        }

        public bool Delete(int id)
        {
            Product theProduct= GetProduct(id);
            if (theProduct != null)
            {
                List<Product> allProducts = GetAllProducts();
                allProducts.Remove(theProduct);
                IDataRepository repo = new BinaryRepository();
                repo.Serialize("products.dat", allProducts);

            }
            return this._products.Remove(theProduct);
        }

        public List<Product> GetAllProducts()
        {
            // return this._products;
            List<Product> products = new List<Product>();
            IDataRepository repository = new BinaryRepository();
            products = repository.Deserialize("products.dat");
            return products;

        }

        public Product GetProduct(int id)
        {
            //foreach (Product theProduct in _products)
            //{
            //    if(theProduct.Id == id) return theProduct;
            //}
            //return null;

            Product foundProduct = null;
            List<Product> products = GetAllProducts();

            foreach (Product product in products)
            {
                if(product.Id == id)
                {
                    foundProduct = product;
                }
            }

            return foundProduct;    
        }

        public bool Insert(Product prod)
        {
            List<Product> allProducts = GetAllProducts();
            allProducts.Add(prod);
            IDataRepository repo = new BinaryRepository();
            repo.Serialize("products.dat", allProducts);

            return false;
        }

        public bool Update(Product prodToUpdate)
        {
            Product theProduct = GetProduct(prodToUpdate.Id);
            if (theProduct != null)
            {
                List<Product> allProducts = GetAllProducts();
                allProducts.Remove(theProduct);
                allProducts.Add(prodToUpdate);
                IDataRepository repo = new BinaryRepository();
                repo.Serialize("products.dat", allProducts);
            }
            return false;
        }
    }
}
