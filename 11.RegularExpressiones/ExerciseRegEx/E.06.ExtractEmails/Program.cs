using System;
using System.Text.RegularExpressions;

namespace E._06.ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\s)([a-zA-Z0-9][\w\-\.]+)+@([a-zA-Z0-9][\w\-\.]+\.[a-zA-Z0-9][\w\-]+)";
            string input = Console.ReadLine();
            MatchCollection matchCollection = Regex.Matches(input,pattern);
            foreach (Match match in matchCollection)
            {
                Console.WriteLine(match);
            }
        }
    }
}
