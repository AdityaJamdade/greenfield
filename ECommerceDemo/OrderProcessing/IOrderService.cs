using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
    public interface IOrderService
    {
        List<Order> GetAllOrders();
        Order GetOrder(int id);

        bool Insert(Order order);
        bool Update(Order order);
        bool Delete(int id);

        List<Order> GetOrdersByDate(DateTime date);

    }
}
