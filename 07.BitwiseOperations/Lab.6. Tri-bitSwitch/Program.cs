using System;

namespace Lab._6._Tri_bitSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int mask = 7 << p;
            int result = number ^ mask;
            Console.WriteLine(result);
        }
    }
}
