using System;

namespace Lab._02.BitAtPosition1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            num >>= 1;
            num &= 1;
            Console.WriteLine(num);
        }
    }
}
