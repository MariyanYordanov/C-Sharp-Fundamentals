using System;
using System.Text.RegularExpressions;

namespace Lab._03.MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?<days>\d{2})(?<separator>[\.\-\/])(?<months>[A-Z][a-z]{2})(\k<separator>)(?<years>\d{4})\b";
            string input = Console.ReadLine();
            MatchCollection dates = Regex.Matches(input, pattern);
            
            foreach (Match date in dates)
            {
                string day = date.Groups["days"].Value;
                string month = date.Groups["months"].Value;
                string year = date.Groups["years"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
