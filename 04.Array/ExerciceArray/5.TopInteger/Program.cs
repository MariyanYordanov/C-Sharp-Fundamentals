using System;
using System.Linq;

namespace ListManipulationAdvanced
{
    class Program
    {
        public static void Main()
        {
            int[] readenArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int temp = readenArray[0];
                for (int j = 0; j < readenArray.Length - 1; j++)
                {
                    readenArray[j] = readenArray[j + 1];
                }
                readenArray[readenArray.Length - 1] = temp;
            }
            Console.WriteLine(string.Join(" ", readenArray));
        }
    }
}