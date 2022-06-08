using System;

namespace Lab._01.BinaryDigitsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int counterZero = 0;
            int counterOne = 0;
            int num = n;
            while (n > 0)
            {
                if (num % 2 == 0)
                {
                    counterZero++;
                }
                else
                {
                    counterOne++;
                }

                num = n / 2;
                n = num;
            }
            if (b == 0)
            {
                Console.WriteLine(counterZero);
            }
            else
            {
                Console.WriteLine(counterOne);
            }
        }
    }
}
