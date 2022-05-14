using System;

namespace _03._Floating_Equality
{
    class Program
    {
        static void Main(string[] args)
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());

            bool eps = false;
            double diff = Math.Abs(first - second);
            if (diff >= 0.000001)
            {
                eps = false;
            }
            else
            {
                eps = true;
            }
            Console.WriteLine(eps);
        }
    }
}
