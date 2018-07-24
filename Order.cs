using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    class Order
    {
        public Customer Cust { set; get; }
        public string OrderName { set; get; }
        public List<Product> Prod { set; get; }

        public Order(string s)
        {
            OrderName = s;
            Prod = new List<Product>();
        }
        public double Payment()
        {
            double orderPrice = 0.0;
            foreach (Product pr in Prod)
                orderPrice += pr.Price;
            return orderPrice;
        }
    }
}
