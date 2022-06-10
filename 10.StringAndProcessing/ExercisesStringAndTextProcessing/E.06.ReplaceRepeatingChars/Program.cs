using System;
using System.Text;

namespace _06.ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder SB = new StringBuilder();
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] != input[i + 1])
                {
                    SB.Append(input[i]);
                }

            }

            SB.Append(input[input.Length - 1]);

            Console.WriteLine(SB);
        }

    }
}
