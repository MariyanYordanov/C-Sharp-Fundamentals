using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace E._05.NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex damagePattern = new Regex(@"-?\d+\.?\d*");
            Regex healthPattern = new Regex(@"[^\+\-\*\/\.\,0-9 ]");
            Regex signsPattern = new Regex(@"[\/\*]");
            string splitPattern = @"[,\s]+";
            string input = Console.ReadLine();
            string[] demons = Regex.Split(input, splitPattern).OrderBy(x => x).ToArray();
            foreach (var demon in demons)
            {
                string demonName = demon;
                MatchCollection damageCollection = damagePattern.Matches(demon);
                double damagePoints = 0;
                foreach (Match damage in damageCollection)
                {
                    double digit = double.Parse(damage.Value);
                    damagePoints += digit;
                }

                MatchCollection healthCollection = healthPattern.Matches(demon);
                double healthPoints = 0;
                foreach (Match health in healthCollection)
                {
                    char points = char.Parse(health.Value);
                    healthPoints += points;
                }

                MatchCollection signsCollection = signsPattern.Matches(demon);
                foreach (Match signs in signsCollection)
                {
                    string sign = signs.Value;
                    if (damagePoints > 0)
                    {
                        if (sign == "/")
                        {
                            damagePoints /= 2;
                        }
                        else if (sign == "*")
                        {
                            damagePoints *= 2;
                        }
                    }

                }

                Console.WriteLine($"{demonName} - {healthPoints} health, {damagePoints:f2} damage");
            }
        }
    }
}
