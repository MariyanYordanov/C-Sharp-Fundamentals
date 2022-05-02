using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _1._2.AdAstra
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(?<sep>[\|\#]{1,2})(?<itemname>[A-Za-z ]+)(\k<sep>)(?<expirationdate>[0-9]{2}\/[0-9]{2}\/[0-9]{2})(\k<sep>)(?<calories>[0-9]{1,4}|10000)(\k<sep>)";
            MatchCollection matchCollection = Regex.Matches(input, pattern);
            matchCollection.Cast<Match>().Select(x => x.Value.Trim()).ToArray();
            int sum = 0;
            foreach (Match match in matchCollection)
            {
                int cal = int.Parse(match.Groups["calories"].Value);
                sum += cal;
            }
            double days = 0;
            if (sum == 0)
            {
                days = 0;
            }
            else
            {
                days = sum / 2000;
            }
            Math.Floor(days);
            Console.WriteLine($"You have food to last you for: {days} days!");
            foreach (Match match in matchCollection)
            {
                string product = match.Groups["itemname"].Value;
                string date = match.Groups["expirationdate"].Value;
                int calories = int.Parse(match.Groups["calories"].Value);
                Console.WriteLine($"Item: {product}, Best before: {date}, Nutrition: {calories}");
            }
        }
    }
}
