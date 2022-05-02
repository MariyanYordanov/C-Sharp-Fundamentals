
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            ulong coolThreshold = 1;

            Regex regex = new Regex(@"([:*]{2})[A-Z][a-z]{2,}\1");

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    coolThreshold *= ulong.Parse(input[i].ToString());
                }
            }

            MatchCollection matches = regex.Matches(input);

            string currentMatch = string.Empty;
            List<string> list = new List<string>();

            foreach (Match match in matches)
            {
                currentMatch = match.Value;
                ulong currentMatchSum = 0;

                for (int i = 0; i < currentMatch.Length; i++)
                {
                    if (char.IsLetter(currentMatch[i]))
                    {
                        currentMatchSum += currentMatch[i];
                    }
                }

                if (currentMatchSum > coolThreshold)
                {
                    list.Add(currentMatch);
                }
            }

            Console.WriteLine($"Cool threshold: {coolThreshold}");
            Console.WriteLine($"{matches.Count} emojis found in the text. The cool ones are:");

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

        }
    }
}

   