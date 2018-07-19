using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    class Product
    {
        public double Price { set; get; }
        public string ProductName { set; get; }
        public Product(string name, double p)
        {
            Price = p;
            ProductName = name;
        }
    }
}
