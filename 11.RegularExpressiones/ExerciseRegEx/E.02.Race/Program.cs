using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;

namespace E._02.Race
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex namesRegex = new Regex(@"(?<name>[A-Za-z]+)");
            Regex distancesRegex = new Regex(@"(?<digit>\d+)");
            string[] participants = Console.ReadLine().Split(", ");
            string input = Console.ReadLine();
            Dictionary<string, int> nameAndDistance = new Dictionary<string, int>();
            foreach (var item in participants)
            {
                nameAndDistance.Add(item,0);
            }

            while (input != "end of race")
            {
                StringBuilder sb = new StringBuilder();
                int distance = 0;
                foreach (var item in namesRegex.Matches(input))
                {
                    sb.Append(item);
                }

                string name = sb.ToString();
                if (nameAndDistance.ContainsKey(name))
                {
                    sb.Clear();
                    foreach (var item in distancesRegex.Matches(input))
                    {
                        sb.Append(item);
                    }

                    string digit = sb.ToString();
                    for (int i = 0; i < digit.Length; i++)
                    {
                        distance += int.Parse(digit[i].ToString());
                    }

                    nameAndDistance[name] += distance;
                }

                input = Console.ReadLine();

            }
            
            var ordered = nameAndDistance.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, y => y.Value);
            Console.WriteLine($"1st place: {ordered.Keys.ElementAt(0)}\n2nd place: {ordered.Keys.ElementAt(1)}\n3rd place: {ordered.Keys.ElementAt(2)}");
        }
    }
}
