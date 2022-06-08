using System;
using System.Linq;
using System.Collections.Generic;

namespace Lab._03.MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOne = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> listTwo = Console.ReadLine().Split().Select(int.Parse).ToList();
            int N = 0;
            if (listOne.Count > listTwo.Count)
            {
                N = listOne.Count;
            }
            else
            {
                N = listTwo.Count;
            }
            List<int> result = new List<int>();
            for (int i = 0; i < N; i++)
            {
                if (i < listOne.Count)
                {
                    result.Add(listOne[i]);
                }
                if (i < listTwo.Count)
                {
                    result.Add(listTwo[i]);
                }
                
            }

            Console.WriteLine(string.Join(" ",result));
        }
    }
}
