using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    class Shop
    {
        public string ShopName { set; get; }     
        public List<Order> Orders { set; get; }

        public Shop(string s)
        {
            ShopName = s;
            Orders = new List<Order>();
        }

        public double ShopRevenue()
        {
            double pros = 0;
            foreach (Order ord in Orders)
            { 
                double m = ord.Cust.Money - ord.Payment();
                if (m > 0)
                    pros += ord.Payment();     
                else
                    pros +=0;
            }
            return pros;
        }
    }
}
