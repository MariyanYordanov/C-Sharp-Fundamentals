using System;

namespace _06._Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int consantNumber = 97;
            for (int i = consantNumber; i < number + consantNumber; i++)
            {
                for (int j = consantNumber; j < number + consantNumber; j++)
                {
                    for (int k = consantNumber; k < number + consantNumber; k++)
                    {
                        Console.WriteLine($"{(char)i}{(char)j}{(char)k}");
                    }
                }
            }
        }
    }
}
