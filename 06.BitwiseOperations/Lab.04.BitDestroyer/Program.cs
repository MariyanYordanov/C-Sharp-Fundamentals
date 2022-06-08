using System;

namespace Lab._04.BitDestroyer
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int mask = ~(1 << p);
            int NewNumber = n & mask;
            Console.WriteLine(NewNumber);
        }
    }
}
