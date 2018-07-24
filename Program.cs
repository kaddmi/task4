using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop shop1 = new Shop("Ромашка");
           
            Order order1 = new Order("ord1");
            order1.Cust = new Customer("J. Ivanova", 100);
            order1.Prod.Add(new Product("pr1", 100));
            order1.Prod.Add(new Product("pr2", 200));
            order1.Prod.Add(new Product("pr3", 50));
            order1.Prod.Add(new Product("pr4", 20));       
            shop1.Orders.Add(order1);
            Order order2 = new Order("ord2");
            order2.Cust = new Customer("A. Pischik", 1000);
            order2.Prod.Add(new Product("pr1", 550));
            order2.Prod.Add(new Product("pr2", 200));
            order2.Prod.Add(new Product("pr3", 50));
            order2.Prod.Add(new Product("pr4", 20));
            shop1.Orders.Add(order2);
            foreach (Order ord in shop1.Orders)
            {
                Console.WriteLine("Customer - {0}, order name - {1},  order payment = {2}", ord.Cust.CustomerName, ord.OrderName, ord.Payment());
                double m = ord.Cust.Money - ord.Payment();
                if (m > 0)
                {
                    Console.WriteLine("Money after payment = {0}", m);
                }
                else Console.WriteLine("Not enough money to pay");
            }
            Console.WriteLine("Shop revenue = {0}", shop1.ShopRevenue());
            Console.Read();
        }
    }
}
