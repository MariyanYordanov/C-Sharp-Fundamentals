using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ME._2.RageQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToUpper();
            Regex regex = new Regex(@"((?<symbols>\D+)(?<repeats>\d+))");
            MatchCollection matchCollection = regex.Matches(input);
            StringBuilder sequence = new StringBuilder();
            foreach (Match match in matchCollection)
            {
                string subSequence = match.Groups["symbols"].Value;
                int number = int.Parse(match.Groups["repeats"].Value);
                for (int i = 0; i < number; i++)
                {
                    sequence.Append(subSequence);
                }

            }

            int counter = sequence.ToString().Distinct().Count();
            Console.WriteLine($"Unique symbols used: {counter}");
            Console.WriteLine(sequence.ToString());
        }
    }
}
