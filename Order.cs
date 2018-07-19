using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    class Order
    {
        public Customer Customer { set; get; }
        public Product Prod { set; get; }
        public int ProdQuantity { set; get; }
        public Order()
        {
            Customer = new Customer();
        }
        public Order(string cs, string name, double p, int n)
        {
            Customer = new Customer(cs);
            Prod = new Product(name, p);
            ProdQuantity = n;
        }
    }
}
