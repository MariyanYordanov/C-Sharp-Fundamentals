using System;

namespace _07._Concat_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string nameLast = Console.ReadLine();
            string specialSymbols = Console.ReadLine();

            Console.WriteLine($"{name}{specialSymbols}{nameLast}");
        }
    }
}
