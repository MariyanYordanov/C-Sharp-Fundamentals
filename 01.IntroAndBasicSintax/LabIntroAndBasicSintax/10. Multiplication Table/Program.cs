using System;

namespace _10._Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int theInteger = int.Parse(Console.ReadLine());

            for (int times = 1; times <= 10; times++)
            {
                int product = times * theInteger;
                Console.WriteLine($"{theInteger} X {times} = {product}");
            }
        }
    }
}
