using Catalog;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ECommerceWeb.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            //List<Product> products = new List<Product>();
            //products.Add(new Product { Id = 1, Name = "gerberas", Description = "Wedding Flower", UnitPrice = 12, Quantity = 3000, ImageUrl = "/Images/gerbera.jpg" });
            //products.Add(new Product { Id = 2, Name = "rose", Description = "Wedding Flower", UnitPrice = 10, Quantity = 5000, ImageUrl = "/Images/gerbera.jpg" });
            //products.Add(new Product { Id = 3, Name = "lily", Description = "Wedding Flower", UnitPrice = 12, Quantity = 1000, ImageUrl = "/Images/gerbera.jpg" });
            //products.Add(new Product { Id = 4, Name = "white lily", Description = "Wedding Flower", UnitPrice = 10, Quantity = 10000, ImageUrl = "/Images/gerbera.jpg" });

            IProductService productService = new ProductService();
            List<Product> products = productService.GetAllProducts();

            return View(products);
        }
        public ActionResult Details()
        {
            return View();
        }

        public ActionResult Insert() 
        {
            return View();
        }

        public ActionResult Update()
        {
            return View();
        }

        public ActionResult Delete()
        {
            return View();
        }

    }
}