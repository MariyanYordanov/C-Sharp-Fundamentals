using System;
using System.Collections.Generic;
using System.Linq;

namespace E._06.CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> first = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> second = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (first.Count != 0 && second.Count != 0)
            {
                if (first[0] > second[0])
                {
                    first.Add(second[0]);
                    first.Add(first[0]);
                    first.RemoveAt(0);
                    second.RemoveAt(0);

                }
                else if (first[0] < second[0])
                {
                    second.Add(first[0]);
                    second.Add(second[0]);
                    second.RemoveAt(0);
                    first.RemoveAt(0);
                }
                else
                {
                    second.RemoveAt(0);
                    first.RemoveAt(0);
                }
            }

            int sum = 0;
            string winner = " ";
            if (first.Count > second.Count)
            {
                for (int i = 0; i < first.Count; i++)
                {
                    sum += first[i];
                    winner = "First";
                }
            }
            else
            {
                for (int i = 0; i < second.Count; i++)
                {
                    sum += second[i];
                    winner = "Second";
                }
            }

            Console.WriteLine($"{winner} player wins! Sum: {sum}");



        }   
    }
}
