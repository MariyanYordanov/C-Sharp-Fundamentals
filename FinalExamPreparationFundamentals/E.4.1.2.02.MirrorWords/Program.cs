using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace E._4._1._2._02.MirrorWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string patterNPairs = @"(?<sep>[\@\#]{1,2})(?<pairs>[A-z]{3,})(\k<sep>{2})(?<pair>[A-z]{3,})(\k<sep>)";
            MatchCollection matchCollection = Regex.Matches(text, patterNPairs);
            matchCollection.Cast<Match>().Select(x => x.Value.Trim()).ToArray();
            if (matchCollection.Count > 0)
            {
                Console.WriteLine($"{matchCollection.Count} word pairs found!");
            }
            else
            {
                Console.WriteLine("No word pairs found!");
            }

            List<string> pairs = new List<string>();
            foreach (Match match in matchCollection)
            {
                string firstPair = match.Groups["pairs"].Value;
                string secondPair = match.Groups["pair"].Value;
                string reversedPair = string.Join("", secondPair.Reverse());
                Match matchPair = Regex.Match(firstPair, reversedPair);
                if (matchPair.Success)
                {
                    pairs.Add(match.Groups["pairs"].Value);
                    pairs.Add(match.Groups["pair"].Value);
                }

            }

            if (pairs.Count == 0)
            {
                Console.WriteLine("No mirror words!");
                return;
            }

            Console.WriteLine("The mirror words are:");
            for (int i = 0; i < pairs.Count; i+=2)
            {
                if (i != 0)
                {
                    Console.Write(", ");
                }
                Console.Write(pairs[i]);
                Console.Write(" <=> ");
                Console.Write(pairs[i+1]);
            }
            
        }
    }
}
