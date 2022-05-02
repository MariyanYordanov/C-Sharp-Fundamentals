using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            double average = (double)input.Sum() / input.Count;
            List<int> ordered = new List<int>();
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] > average)
                {
                    ordered.Add(input[i]);
                }
                else if (input[i] == average)
                {
                    Console.WriteLine("No");
                    return;
                }
            }

            ordered.Sort();
            ordered.Reverse();
            List<int> topFive = new List<int>();
            int j = 0;
            for (int i = 0; i < ordered.Count; i++)
            {
                topFive.Add(ordered[i]);
            }

            if (topFive.Count > 5)
            {
                topFive.RemoveRange(5, topFive.Count - 5);
            }
            
            Console.WriteLine(string.Join(" ", topFive));
        }
    }
}
