﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POCO;

namespace Specification
{
    public interface IProductService
    {
        Product GetProduct(int id);
        List<Product> GetAllProducts();

        bool Insert(Product prod);
        bool Update(Product prod);
        bool Delete(int id);


    }
}
