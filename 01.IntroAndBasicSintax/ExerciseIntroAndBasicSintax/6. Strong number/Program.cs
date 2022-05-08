using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int number = num;
            int sumFactorial = 0;

            while (number > 0)
            {
                int currentNumber = number % 10;
                number /= 10;
                int currentFactorialNumber = 1;

                for (int i = 1; i <= currentNumber; i++)
                {
                    currentFactorialNumber *= i;
                }

                sumFactorial += currentFactorialNumber;
            }

            if (sumFactorial == num)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
