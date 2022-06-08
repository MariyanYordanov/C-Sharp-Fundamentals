using System;
using System.Linq;
using System.Collections.Generic;

namespace Lab._02.Gauss_Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            
            for (int i = 0; i < list.Count / 2; i++)
            {
                int sum = list[i] + list[list.Count - 1 - i];
                Console.Write(sum + " ");
            }

            if (list.Count % 2 != 0)
            {
                Console.WriteLine(list[list.Count / 2]);
            }
        }
    }
}
