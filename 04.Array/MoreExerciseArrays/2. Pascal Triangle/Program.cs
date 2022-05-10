using System;

namespace _02._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            int[] firstRow = new int[3] { 0, 1, 0};
            int[] prevRow = firstRow;
            Console.WriteLine(firstRow[1]);
            for (int i = 0; i < n - 1; i++)
            {
                int[] currentRow = new int[prevRow.Length + 1];
                for (int j = 1; j < currentRow.Length - 1; j++)
                {
                    currentRow[j] = prevRow[j - 1] + prevRow[j];
                    Console.Write(currentRow[j] + " ");
                }
                prevRow = currentRow;
                Console.WriteLine();
            }
        }
    }
}
