using System;

namespace ME._02.AsciiSumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            int startIndex = Math.Min(first, second);
            int endIndex = Math.Max(first, second);
            string input = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > startIndex && input[i] < endIndex)
                {
                    sum += input[i];
                }
                
            }
            Console.WriteLine(sum);
        }
    }
}
