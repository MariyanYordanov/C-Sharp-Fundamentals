using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ME._3.PostOffice
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] carries = input.Split("|");
            var regexForCapitalLetters = new Regex(@"[#$%*&](?<letters>[A-Z]+)[#$%*&]");
            var regexForWordsData = new Regex(@"(?<capitalLetter>\d+):(?<wordLength>[0-9][0-9])");
            var regexForCapitalSpaces = new Regex(@"\b(?<firstLetter>[A-Z])(?<after>[a-z]+-?[A-Z]?[a-z-]*)\b");
            var matchesCapitalLetters = regexForCapitalLetters.Matches(carries[0]);
            var matchesWordsData = regexForWordsData.Matches(carries[1]);
            var matchesSpaces = regexForCapitalSpaces.Matches(carries[2]);
            foreach (Match letter in matchesCapitalLetters)
            {
                string code = letter.Groups["letters"].Value;
                for (int i = 0; i < code.Length; i++)
                {
                    foreach (Match matches in matchesWordsData)
                    {
                        int caritalLetter = int.Parse(matches.Groups["capitalLetter"].Value);
                        int wordLength = int.Parse(matches.Groups["wordLength"].Value);
                        if (caritalLetter == code[i])
                        {
                            foreach (Match length in matchesSpaces)
                            {
                                char firstLetter = char.Parse(length.Groups["firstLetter"].Value);
                                int lengthOfWord = length.Groups["after"].Value.Length;
                                if (firstLetter == caritalLetter && lengthOfWord == wordLength)
                                {
                                    Console.WriteLine(length);
                                    break;
                                }

                            }

                            break;
                        }

                    }

                }

            }

            //Best solution from colega

            //string[] input = Console.ReadLine().Split("|");

            //string firstPart = input[0];
            //string secondPart = input[1];
            //string thirdPart = input[2];

            //string firstPattern = @"([#$%*&])(?<capitals>[A-Z]+)(\1)";
            //Match firstMatch = Regex.Match(firstPart, firstPattern);
            //string capitals = firstMatch.Groups["capitals"].Value;

            //for (int index = 0; index < capitals.Length; index++)
            //{
            //    char startLetter = capitals[index];
            //    int ASCIIcode = startLetter;

            //    string secondPattern = $@"{ASCIIcode}:(?<length>[0-9][0-9])";
            //    Match secondMatch = Regex.Match(secondPart, secondPattern);
            //    int length = int.Parse(secondMatch.Groups["length"].Value);

            //    string thirdPattern = $@"(?<=\s|^){startLetter}[^\s]{{{length}}}(?=\s|$)";
            //    Match thirdMatch = Regex.Match(thirdPart, thirdPattern);
            //    string word = thirdMatch.ToString();

            //    Console.WriteLine(word);

        }
    }
}
