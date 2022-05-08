using System;

namespace _02._Division
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());

            switch (num)
            {
                case double divider when divider % 10 == 0:
                    Console.WriteLine($"The number is divisible by 10");
                    break;                                          
                case double divider when divider % 7 == 0:          
                    Console.WriteLine($"The number is divisible by 7");
                    break;                                          
                case double divider when divider % 6 == 0:          
                    Console.WriteLine($"The number is divisible by 6");
                    break;                                          
                case double divider when divider % 3 == 0:         
                    Console.WriteLine($"The number is divisible by 3");
                    break;                                          
                case double divider when divider % 2 == 0:          
                    Console.WriteLine($"The number is divisible by 2");
                    break;
                default:
                    Console.WriteLine("Not divisible");
                    break;
            }
        }
    }
}
