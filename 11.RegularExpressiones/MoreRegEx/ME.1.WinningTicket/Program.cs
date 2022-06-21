using System;
using System.Text.RegularExpressions;

namespace ME._1.WinningTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string splitPattern = @"[,\s]+";
            string symbol = @"\@{6,}|\#{6,}|\${6,}|\^{6,}";
            string input = Console.ReadLine();
            string[] splitInput = Regex.Split(input, splitPattern);
            foreach (string text in splitInput)
            {
                if (text.Length == 20)
                {
                    string ticket = text;
                    string left = text.Substring(0,10);
                    string right = text.Substring(10,10);
                    Match sumbolLeft = Regex.Match(left, symbol);
                    Match sumbolRight = Regex.Match(right, symbol);
                    if (sumbolLeft.Success && sumbolRight.Success)
                    {
                        int minSumNumber = Math.Min(sumbolLeft.Length, sumbolRight.Length);
                        if (minSumNumber == 10)
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {minSumNumber}{sumbolLeft.Value[0]} Jackpot!");
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {minSumNumber}{sumbolLeft.Value[0]}");
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
