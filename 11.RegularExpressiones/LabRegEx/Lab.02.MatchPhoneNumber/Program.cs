using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace Lab._02.MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+359(?<sep>[ -])2(\k<sep>)\d{3}(\k<sep>)\d{4}\b";
            string input = Console.ReadLine();
            MatchCollection matchCollection = Regex.Matches(input,pattern);
            matchCollection.Cast<Match>().Select(x => x.Value.Trim()).ToArray();
            Console.WriteLine(string.Join(", ",matchCollection));
        }
    }
}
