using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop shop1 = new Shop("Ромашка");
            shop1.Orders.Add(new Order("A. Pischik", "pr1", 100, 2));
            shop1.Orders.Add(new Order("A. Pischik", "pr2", 200, 3));
            shop1.Orders.Add(new Order("A. Pischik", "pr3", 300, 1));
            shop1.Orders.Add(new Order("J. Ivanova", "pr1", 100, 2));
            shop1.Orders.Add(new Order("J. Ivanova", "pr2", 200, 3));
            shop1.Orders.Add(new Order("J. Ivanova", "pr3", 300, 1));
            Console.WriteLine(shop1.Payment());
            Console.WriteLine(shop1.Payment("A. Pischik"));
            Console.WriteLine("Shop name: {0}", shop1.ShopName);
            foreach (Order ord in shop1.Orders)
            {
                Console.WriteLine("Customer: {0}; Prod Name: {1}; Prod Price: {2}; Prod Quant: {3};", ord.Customer.CustomerName, ord.Prod.ProductName, ord.Prod.Price, ord.ProdQuantity);
            }
                Console.Read();
        }
    }
}
