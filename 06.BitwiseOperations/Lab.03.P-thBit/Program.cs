using System;

namespace Lab._03.P_thBit
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            n >>= p;
            n &= 1;
            Console.WriteLine(n);
        }
    }
}
