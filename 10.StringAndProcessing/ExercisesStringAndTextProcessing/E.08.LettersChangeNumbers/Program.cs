using System;

namespace E._08.LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            double sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                double number = double.Parse(input[i].Substring(1, input[i].Length - 2));
                char firstLetter = input[i][0];
                char lastLetter = input[i][input[i].Length - 1];
                if (char.IsUpper(firstLetter))
                {
                    int position = firstLetter - 64;
                    number /= position;
                }
                else
                {
                    int position = firstLetter - 96;
                    number *= position;
                }

                if (char.IsUpper(lastLetter))
                {
                    int position = lastLetter - 64;
                    number -= position;
                }
                else
                {
                    int position = lastLetter - 96;
                    number += position;
                }

                sum += number;
            }

            Console.WriteLine($"{sum:f2}");
        }
    }
}
