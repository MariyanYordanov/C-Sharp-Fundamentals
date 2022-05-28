using System;
using System.Collections.Generic;
using System.Linq;

namespace E._07.AppendArrays
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //1 2 3 |4 5 6 |  7  8  - input
            //7 8 4 5 6 1 2 3  - output
            List<string> input = Console.ReadLine().Split("|").Reverse().ToList();
            
            List<int> list = new List<int>();

            foreach (var item in input)
            {
                list.AddRange(item.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
