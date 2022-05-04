using System;
using System.Linq;

namespace _08._Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] readenArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < readenArray.Length; i++)
            {
                for (int j = i + 1; j < readenArray.Length; j++)
                {
                    int sum = readenArray[i] + readenArray[j];
                    if (sum == number)
                    {
                        Console.WriteLine($"{readenArray[i]} {readenArray[j]}");
                    }
                }
            }
        }
    }
}
