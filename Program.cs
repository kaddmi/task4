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
            Console.WriteLine(shop1.ShopPrice());
            Console.WriteLine(shop1.OrderPrice("A. Pischik"));
            Console.Read();
        }
    }
}
