using System;
using System.Linq;
using System.Numerics;

namespace _02._From_Left_to_The_Right
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                BigInteger[] numbers = Console.ReadLine().Split(" ").Select(BigInteger.Parse).ToArray();
                BigInteger sum = 0;
                int digit = 0;
                if (numbers[0] >= numbers[1])
                {
                    while (numbers[0] != 0)
                    {
                        digit = (int)Math.Abs((decimal)numbers[0] % 10);
                        numbers[0] /= 10;
                        sum += digit;
                    }
                }
                else
                {
                    while (numbers[1] != 0)
                    {
                        digit = (int)Math.Abs((decimal)numbers[1] % 10);
                        numbers[1] /= 10;
                        sum += digit;
                    }
                }
                Console.WriteLine(sum);
            }
        }
    }
}
