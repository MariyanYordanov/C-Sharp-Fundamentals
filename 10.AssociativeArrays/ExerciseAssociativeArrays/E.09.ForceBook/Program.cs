using System;
using System.Collections.Generic;
using System.Linq;

namespace E._09.ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> force = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();
            while (input != "Lumpawaroo")
            {
                if (input.Contains("|"))
                {
                    string[] cmd = input.Split(" | ");
                    string forceSide = cmd[0];
                    string forceUser = cmd[1];
                    if (!force.ContainsKey(forceSide))
                    {
                        force.Add(forceSide, new List<string>());
                    }

                    if (!force[forceSide].Contains(forceUser) && !force.Values.Any(users => users.Contains(forceUser)))
                    {
                        force[forceSide].Add(forceUser);
                    }
                }
                else if (input.Contains("->"))
                {
                    string[] cmd = input.Split(" -> ");
                    string forceSide = cmd[1];
                    string forceUser = cmd[0];
                    if (!force.Values.Any(user => user.Contains(forceUser)))
                    {
                        if (!force.ContainsKey(forceSide))
                        {
                            force.Add(forceSide, new List<string>());
                        }
                        force[forceSide].Add(forceUser);
                        Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                    }
                    else
                    {
                        foreach (var side in force.Where(sides => sides.Value.Contains(forceUser)))
                        {
                            side.Value.Remove(forceUser);
                        }

                        if (!force.ContainsKey(forceSide))
                        {
                            force.Add(forceSide, new List<string>());
                        }

                        force[forceSide].Add(forceUser);
                        Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                    }
                    
                }
               
                input = Console.ReadLine();
            }
            force = force.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);
            foreach (var forceSide in force)
            {
                forceSide.Value.Sort();
                if (forceSide.Value.Count > 0)
                {
                    Console.WriteLine($"Side: {forceSide.Key}, Members: {forceSide.Value.Count}");
                    Console.Write("! ");
                    Console.WriteLine($"{string.Join("\n! ", forceSide.Value)}");
                }

            }

        }
    }
}
