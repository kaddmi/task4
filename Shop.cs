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

        public double Payment()
        {
            double orderPrice = 0.0;
            foreach (Order ord in Orders)
                orderPrice += ord.Prod.Price * ord.ProdQuantity;
            return orderPrice;
        }

         public double Payment(string s)
         {
            double orderPrice = 0.0;
            foreach (Order ord in Orders)
                if (ord.Customer.CustomerName == s)
                    orderPrice += ord.Prod.Price * ord.ProdQuantity;
            return orderPrice;
         }

    }
}
