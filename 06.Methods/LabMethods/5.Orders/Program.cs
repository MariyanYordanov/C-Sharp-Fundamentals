using System;

namespace _05.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            Price(product, quantity);
        }

        static void Price(string product, int quantity) 
        {
            if (product == "coffee")
            {
                double price = quantity * 1.50;
                Console.WriteLine($"{price:f2}");
            }
            else if (product == "water")
            {
                double price = quantity * 1.00;
                Console.WriteLine($"{price:f2}");
            }
            else if (product == "coke")
            {
                double price = quantity * 1.40;
                Console.WriteLine($"{price:f2}");
            }
            else if (product == "snacks")
            {
                double price = quantity * 2.00;
                Console.WriteLine($"{price:f2}");
            }
        }
    }
}
