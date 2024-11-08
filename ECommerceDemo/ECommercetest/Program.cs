using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRM;
using OrderProcessing;
using Catalog;

namespace ECommerceTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 89;
            product1.Name = "TV";
            product1.Description = "The TV";
            product1.UnitPrice = 10000;
            product1.Quantity = 4;
            product1.ImageUrl = "image1.example.com";

            Product product2 = new Product();
            product2.Id = 22;
            product2.Name = "FRIDGE";
            product2.Description = "The FRIDGE";
            product2.UnitPrice = 23000;
            product2.Quantity = 9;
            product2.ImageUrl = "image1.example.com";

            IProductService productService = new ProductService();
            
            productService.Insert(product1);
            productService.Insert(product2);

            List<Product> products = productService.GetAllProducts();


            foreach (Product product in products)
            {
                Console.WriteLine($"{product.Id}, Name - {product.Name}, Description - {product.Description}, Quantity - {product.Quantity}, Price/Unit - {product.UnitPrice}");
                Console.WriteLine();
            }


            productService.Delete(22);
            productService.Update(product2);

            List<Product> products2 = productService.GetAllProducts();

            Console.WriteLine("After deletion");
            foreach (Product product in products2)
            {
                Console.WriteLine($"Product {product.Id}, {product.Name}, {product.Description}, {product.Quantity}, {product.UnitPrice}");
                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}


//Customer customer1 = new Customer();
//customer1.Id = 89;
//customer1.FirstName = "Rajas";
//customer1.LastName = "Doshi";
//customer1.Email = "rp@gmail.com";
//customer1.Contact = "9038498038";

//Customer customer2 = new Customer();
//customer2.Id = 89;
//customer2.FirstName = "Ash";
//customer2.LastName = "Pandey";
//customer2.Email = "ap@gmail.com";
//customer2.Contact = "8964498038";

//ICustomerService customerService = new CustomerService();

//customerService.Insert(customer1);
//customerService.Insert(customer2);

//List<Customer> allCustomers = customerService.GetAll();

//foreach (Customer customer in allCustomers)
//{
//    Console.WriteLine(customer.FirstName);
//    Console.WriteLine(customer.LastName);
//    Console.WriteLine(customer.Email);
//    Console.WriteLine(customer.Contact);
//    Console.WriteLine();
//}

//Order order1 = new Order();
//order1.Id = 89;
//order1.Amount = 7800;
//order1.Status = "Delivered";
//order1.Date = new DateTime(2024, 10, 15);

//Order order2 = new Order();
//order2.Id = 78;
//order2.Amount = 900;
//order2.Status = "Cancelled";
//order2.Date = new DateTime(2024, 11, 24);


//IOrderService orderService = new OrderService();

//orderService.Insert(order1);
//orderService.Insert(order2);

//List<Order> orders = orderService.GetAllOrders();

//foreach (Order order in orders)
//{
//    Console.WriteLine(order.Id);
//    Console.WriteLine(order.Amount);
//    Console.WriteLine(order.Status);
//    Console.WriteLine($"Date: {order.Date.ToString("dd-MM-yyyy")}");
//    Console.WriteLine();
//}


//orderService.Delete(90);

//List<Order> orders2 = orderService.GetAllOrders();

//Console.WriteLine("After deletion");
//foreach (Order order in orders2)
//{
//    Console.WriteLine(order.Id);
//    Console.WriteLine(order.Amount);
//    Console.WriteLine(order.Status);
//    Console.WriteLine($"Date: {order.Date.ToString("dd-MM-yyyy")}");
//    Console.WriteLine();
//}