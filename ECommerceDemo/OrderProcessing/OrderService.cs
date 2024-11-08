using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
    public class OrderService : IOrderService
    {
        private List<Order> _orders;
        public OrderService()
        {
            this._orders = new List<Order>();
        }
        public bool Delete(int id)
        {
            Order theOrder = this._orders.Find(o => o.Id == id);
            Debug.WriteLine(theOrder.Amount);
            
            _orders.Remove(theOrder);
            return true;
        }

        public List<Order> GetAllOrders()
        {
             return _orders;
        }

        public Order GetOrder(int id)
        {
            foreach (Order theOrder in _orders)
            {
                if(theOrder.Id == id) return theOrder;
            }
            return null;
        }

        public bool Insert(Order order)
        {
            this._orders.Add(order);
            return true;
        }

        public bool Update(Order order)
        {
            this.Delete(order.Id);
            this.Insert(order);
            return true;
        }

        public List<Order> GetOrdersByDate(DateTime date)
        {
            // Filter orders where the OrderDate matches the specified date
            return _orders.FindAll(order => order.Date == date.Date).ToList();
        }

    }
}
