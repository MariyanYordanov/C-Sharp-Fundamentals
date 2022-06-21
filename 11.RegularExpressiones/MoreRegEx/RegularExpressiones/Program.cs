using System;
using System.Text.RegularExpressions;

namespace ME._1.WinningTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string splitPattern = @"[,\s]+";
            string pattern = @"(?<half>[\@\#\$\^]{6,10})(.*)\k<half>";
            string symbols = @"[\@\#\$\^]{6,10}";
            string input = Console.ReadLine();
            string[] splitInput = Regex.Split(input, splitPattern);
            foreach (string text in splitInput)
            {
                if (text.Length == 20)
                {
                    string ticket = text;
                    if (Regex.IsMatch(text, pattern))
                    {
                        MatchCollection symbolMatch = Regex.Matches(text, symbols);
                        char symbol = symbolMatch[0].Value[0];
                        int matchLength = 0;
                        for (int i = 0; i < symbolMatch[0].Value.Length; i++)
                        {
                            if (symbol == symbolMatch[0].Value[i])
                            {
                                matchLength++;
                            }
                        }

                        if (matchLength == 10)
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {matchLength}{symbol} Jackpot!");
                        }
                        else if (matchLength >= 6 && matchLength <= 9)
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {matchLength}{symbol}");
                        }

                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }

                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }
            }
        }
    }
}
