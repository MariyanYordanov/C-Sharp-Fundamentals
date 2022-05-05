using System;

namespace _11._Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int theInteger = int.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());

            do
            {
                int product = times * theInteger;
                Console.WriteLine($"{theInteger} X {times} = {product}");
                times += 1;
            } while (times <= 10);
        }
    }
}
