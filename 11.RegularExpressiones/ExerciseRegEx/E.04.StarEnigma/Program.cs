using System;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace E._04.StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string planetPattern = @"@(?<name>[A-z]+)[^@\-!:>]*:(?<population>\d+)!(?<attack>[A,D])![^@\-!:>]*->(?<soldier>\d+)";
            List<string> attackedPlanet = new List<string>();
            List<string> destroyedPlanet = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                int key = input.ToLower().Count(x => x == 's' || x == 't' || x == 'a' || x == 'r');
                StringBuilder sb = new StringBuilder();
                for (int j = 0; j < input.Length; j++)
                {
                    char letter = (char)(input[j] - key);
                    sb.Append(letter);
                }

                string decrypted = sb.ToString();
                MatchCollection matchCollection = Regex.Matches(decrypted, planetPattern);
                foreach (Match match in matchCollection)
                {
                    string planetName = match.Groups["name"].Value;
                    char attackType = char.Parse(match.Groups["attack"].Value);
                    
                    if (attackType == 'A')
                    {
                        attackedPlanet.Add(planetName);
                    }
                    else
                    {
                        destroyedPlanet.Add(planetName);
                    }

                }
                
                sb.Clear();
               
            }

            Console.WriteLine($"Attacked planets: {attackedPlanet.Count}");
            attackedPlanet.OrderBy(x => x).ToList().ForEach(x => Console.WriteLine($"-> {x}"));
            Console.WriteLine($"Destroyed planets: {destroyedPlanet.Count}");
            destroyedPlanet.OrderBy(x => x).ToList().ForEach(x => Console.WriteLine($"-> {x}"));
        }
    }
}
