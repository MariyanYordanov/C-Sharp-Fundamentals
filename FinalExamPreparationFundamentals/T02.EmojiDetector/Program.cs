using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace T02.EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string patternEmoji = @"(?<sep>\*{2}|\:{2})(?<emoji>[A-Z][a-z]{2,})\k<sep>";
            string patternDigits = @"\d";
            int coolThresholdSum = 1;
            MatchCollection matchCollectionDigits = Regex.Matches(input, patternDigits);
            foreach (Match match in matchCollectionDigits)
            {
                int cool = int.Parse(match.Value);
                coolThresholdSum *= cool;
            }

            MatchCollection matchCollectionEmoji = Regex.Matches(input, patternEmoji);
            matchCollectionEmoji.Cast<Match>().Select(x => x.Value.Trim()).ToArray();
            List<string> coolestEmoji = new List<string>();
            foreach (Match match in matchCollectionEmoji)
            {
                string emoji = match.Groups["emoji"].Value;
                string separator = match.Groups["sep"].Value;
                int coolness = 0;
                for (int i = 0; i < emoji.Length; i++)
                {
                    coolness += emoji[i];
                }

                if (coolness > coolThresholdSum)
                {
                    string emojiAdd = separator+emoji+separator;
                    coolestEmoji.Add(emojiAdd);
                }
            }

            Console.WriteLine($"Cool threshold: {coolThresholdSum}");
            Console.WriteLine($"{matchCollectionEmoji.Count} emojis found in the text. The cool ones are: \n{string.Join("\n", coolestEmoji)}");

            //string s = "some text";
            //s = new string(s.ToCharArray().Reverse().ToArray());
            //Console.WriteLine(s);
        }
    }
}
