using System;
using System.Linq;

namespace Lab._05.OddTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                result ^= arr[i];
            }
            Console.WriteLine(result);
        }
    }
}
