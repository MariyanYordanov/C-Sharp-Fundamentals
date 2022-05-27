using System;
using System.Linq;
using System.Collections.Generic;

namespace Lab._04.ListOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> orderProducts = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string product = Console.ReadLine();
                orderProducts.Add(product);
            }

            orderProducts.Sort();
            
            for (int i = 0; i < orderProducts.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{orderProducts[i]}");
            }
            
        }
    }
}
