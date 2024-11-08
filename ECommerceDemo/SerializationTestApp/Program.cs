using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services;
using POCO;

namespace SerializationTestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductService svc = new ProductService();
            svc.Seeding();
            List<Product> allProducts = svc.GetAllProducts();
            foreach (Product product in allProducts)
            {
                Console.Write(product.Name);
            }
            Console.ReadLine();
        }
    }
}
