using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace E._01.Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @">>(?<product>[A-Za-z\s]+)<<(?<price>\d+(.\d+)?)!(?<quantity>\d+)";
            List<string> furniture = new List<string>();
            double total = 0;
            while ( input != "Purchase")
            {
                Match matches = Regex.Match(input,pattern,RegexOptions.IgnoreCase);
                if (matches.Success)
                {
                    string name = matches.Groups["product"].Value;
                    double price = double.Parse(matches.Groups["price"].Value);
                    int quantity = int.Parse(matches.Groups["quantity"].Value);
                    furniture.Add(name);
                    total += price * quantity;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine("Bought furniture:");
            furniture.ForEach(Console.WriteLine);
            Console.WriteLine($"Total money spend: {total:f2}");
        }
    }
}
