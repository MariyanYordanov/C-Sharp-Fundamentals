using System;
using System.Text.RegularExpressions;

namespace E._03._SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%(?<name>[A-Z][a-z]+)%[^|$%.]*?<(?<product>\w+)>[^|$%.]*?\|(?<counter>\d+)\|[^|$%.]*?(?<price>[\d]+[.]?[\d]+)?\$";
            string input = Console.ReadLine();
            double totalPrice = 0;
            while (input != "end of shift")
            {
                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    string product = match.Groups["product"].Value;
                    double price = double.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["counter"].Value);
                    double total = price * quantity;
                    totalPrice += total;
                    Console.WriteLine($"{name}: {product} - {total:f2}");
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {totalPrice:f2}");
        }
    }
}
