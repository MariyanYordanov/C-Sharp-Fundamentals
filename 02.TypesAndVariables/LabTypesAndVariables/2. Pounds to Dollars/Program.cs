using System;

namespace _02._Pounds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal dollar = decimal.Parse(Console.ReadLine());

            decimal pound = dollar * 1.31m;

            Console.WriteLine($"{pound:f3}");
        }
    }
}
