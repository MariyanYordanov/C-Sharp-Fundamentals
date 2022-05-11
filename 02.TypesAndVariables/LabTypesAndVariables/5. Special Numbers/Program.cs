using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool specialNumber;

            for (int i = 1; i <= n; i++)
            {
                int sum = 0;
                int last = i;
                while (last > 0)
                {
                    sum += last % 10;
                    last /= 10;
                }

                if (sum == 5 || sum == 7 || sum == 11)
                {
                    specialNumber = true;
                }
                else
                {
                    specialNumber = false;
                }

                Console.WriteLine($"{i} -> {specialNumber}");
            }
        }
    }
}

