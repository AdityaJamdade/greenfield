using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    internal interface ICartService
    {
        List<Cart> GetItems();

        bool AddToCart(Item item);

        bool RemoveFromCart(Item item);

        bool Clear();
    }
}
