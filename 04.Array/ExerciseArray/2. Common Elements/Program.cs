using System;
using System.Linq;

namespace _002._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] first = Console.ReadLine().Split(" ").ToArray();
            string[] second = Console.ReadLine().Split(" ").ToArray();

            for (int i = 0; i < second.Length; i++)
            {
                for (int j = 0; j < first.Length; j++)
                {
                    if (first[j] == second[i])
                    {
                        Console.Write(second[i] + " ");
                    }
                }
            }
        }
    }
}
