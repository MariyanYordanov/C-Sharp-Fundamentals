using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] firstArray = new int[n];
            int[] secondArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                int[] tempArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < tempArray.Length; j++)
                {
                    if (i % 2 == 0)
                    {
                        secondArray[i] = tempArray[0];
                        firstArray[i] = tempArray[1];
                    }
                    else
                    {
                        secondArray[i] = tempArray[1];
                        firstArray[i] = tempArray[0];
                    }
                }
            }
            Console.WriteLine(string.Join(" ", firstArray));
            Console.WriteLine(string.Join(" ", secondArray));
        }
    }
}
