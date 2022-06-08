using System;
using System.Collections.Generic;
using System.Linq;

namespace ME._04.List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> result = new List<int>();
            
            if (firstList.Count > secondList.Count)
            {
                int start = firstList[firstList.Count - 2];
                int end = firstList[firstList.Count - 1];
                int biggerNumber = 0;
                int smallerNumber = 0;
                if (start > end)
                {
                    biggerNumber = start;
                    smallerNumber = end;
                }
                else
                {
                    biggerNumber = end;
                    smallerNumber = start;
                }
                for (int k = 0; k < secondList.Count; k++)
                {
                    result.Add(firstList[k]);
                    result.Add(secondList[secondList.Count - k - 1]);
                }
                secondList.Clear();
                for (int i = 0; i < result.Count; i++)
                {
                    if (result[i] > smallerNumber && result[i] < biggerNumber)
                    {
                        secondList.Add(result[i]);
                    }
                }

                secondList.Sort();
                Console.Write(string.Join(" ",secondList));

            }
            else
            {
                int start = secondList[0];
                int end = secondList[1];
                int biggerNumber = 0;
                int smallerNumber = 0;
                if (start > end)
                {
                    biggerNumber = start;
                    smallerNumber = end;
                }
                else
                {
                    biggerNumber = end;
                    smallerNumber = start;
                }
                for (int k = 0; k < firstList.Count; k++)
                {
                    result.Add(firstList[k]);
                    result.Add(secondList[secondList.Count - k - 1]);
                }
                firstList.Clear();
                for (int i = 0; i < result.Count; i++)
                {
                    if (result[i] > smallerNumber && result[i] < biggerNumber)
                    {
                        firstList.Add(result[i]);
                    }

                }

                firstList.Sort();
                Console.Write(string.Join(" ", firstList));
            }
        }
    }
}
