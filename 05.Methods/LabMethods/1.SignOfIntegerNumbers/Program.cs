using System;

namespace _5.Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            EvenOrOddNumber(n);
        }

        static void EvenOrOddNumber (int a)
        {
           
            if (a > 0)
            {
                Console.WriteLine($"The number {a} is positive.");
            }
            else if (a < 0)
            {
                Console.WriteLine($"The number {a} is negative.");
            }
            else 
            {
                Console.WriteLine($"The number {a} is zero.");
                
            }
        }
    }
}
