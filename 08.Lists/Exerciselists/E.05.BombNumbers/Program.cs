using System;
using System.Collections.Generic;
using System.Linq;

namespace E._05.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] powerRange = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sum = 0;
            int power = powerRange[0];
            int index = powerRange[1];

            for (int i = 0; i < list.Count; i++)
            {
                if (power == list[i])
                {
                    int n = (index * 2) + 1;
                    int start = i - index;
                    int end = n + start;
                    if (start < 0 )
                    {
                        start = 0;
                    }
                    if (end > list.Count)
                    {
                        end = list.Count;
                    }
                    for (int j = start; j < end; j++)
                    {
                        list.RemoveAt(j);
                        list.Insert(j,0);
                    }
                    
                }
               
            }
            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }
            Console.WriteLine(sum);
        }
    }
}
