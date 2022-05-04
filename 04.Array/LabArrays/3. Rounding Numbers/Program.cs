using System;
using System.Linq;

namespace _03._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] num = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] == 0)
                {
                    num[i] = 0;
                }
               int rounded = (int)Math.Round(num[i], MidpointRounding.AwayFromZero);
                Console.WriteLine("{0} => {1}", num[i], rounded);
            }
        }
    }
}
