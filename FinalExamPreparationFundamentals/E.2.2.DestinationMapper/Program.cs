using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace E._2._2.DestinationMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<div>[=\/])(?<word>[A-Z][A-Za-z]{2,})(\k<div>)";
            string places = Console.ReadLine();
            int sumLength = 0;
            List<string> destinations = new List<string>();
            MatchCollection matchCollection = Regex.Matches(places, pattern);
            foreach (Match match in matchCollection)
            {
                string destination = match.Groups["word"].Value;
                sumLength += destination.Length;
                destinations.Add(destination);
            }

            Console.Write($"Destinations: {string.Join(", ",destinations)}");
            Console.WriteLine();
            Console.WriteLine($"Travel Points: {sumLength}");
        }
    }
}
