using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    class Customer
    {
        public string CustomerName { set; get; }
        public Customer()
        {

        }
        public Customer(string name)
        {
            CustomerName = name;
        }
    }
}
