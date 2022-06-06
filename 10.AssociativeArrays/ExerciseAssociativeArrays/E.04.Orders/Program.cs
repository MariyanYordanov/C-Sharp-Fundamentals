using System;
using System.Collections.Generic;
using System.Linq;

namespace E._04.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> order = new Dictionary<string, double>();
            Dictionary<string, int> newOrder = new Dictionary<string, int>();
            string input = Console.ReadLine();
            
            while (input != "buy")
            {
                string[] tokens = input.Split();
                string productName = tokens[0];
                double productPrice = double.Parse(tokens[1]);
                int productQuantity = int.Parse(tokens[2]);
                if (!newOrder.ContainsKey(productName))
                {
                    order.Add(productName, productPrice);
                    newOrder.Add(productName, productQuantity);
                }
                else
                {
                    order.Remove(productName);
                    order.Add(productName, productPrice);
                    newOrder[productName] += productQuantity;
                }
                
                input = Console.ReadLine();
            }

            foreach (var itemP in order)
            {
                foreach (var itemQ in newOrder)
                {
                    if (itemQ.Key == itemP.Key)
                    {
                        Console.WriteLine($"{itemP.Key} -> {(itemQ.Value * itemP.Value):F2}");
                    }
                }
                
            }
        }
    }
}
