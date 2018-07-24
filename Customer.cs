using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    class Customer
    {
        public string CustomerName { set; get; }
        public double Money { set; get; }
        public Customer()
        {

        }
        public Customer(string name, double m)
        {
            CustomerName = name;
            Money = m;
        }
    }
}
