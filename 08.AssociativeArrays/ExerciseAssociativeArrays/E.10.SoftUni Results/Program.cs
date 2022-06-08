using System;
using System.Linq;
using System.Collections.Generic;

namespace E._10.SoftUni_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> namesAndGrades = new Dictionary<string, List<int>>();
            Dictionary<string, List<string>> languageAndSubmitions = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();
            while (input != "exam finished")
            {
                string[] cmd = input.Split("-");
                if (cmd.Length == 3)
                {
                    string username = cmd[0];
                    string language = cmd[1];
                    int points = int.Parse(cmd[2]);
                    if (!languageAndSubmitions.ContainsKey(language))
                    {
                        languageAndSubmitions.Add(language, new List<string>());
                        languageAndSubmitions[language].Add(username); 
                    }
                    else if (languageAndSubmitions.ContainsKey(language))
                    {
                        languageAndSubmitions[language].Add(username);
                    }

                    if (!namesAndGrades.ContainsKey(username))
                    {
                        namesAndGrades.Add(username, new List<int>());
                        namesAndGrades[username].Add(points);
                    }
                    else if (namesAndGrades.ContainsKey(username))
                    {
                        namesAndGrades[username].Add(points);
                    }
                }
                else if (cmd.Length == 2)
                {
                    string username = cmd[0];
                    if (namesAndGrades.ContainsKey(username))
                    {
                        namesAndGrades.Remove(username);
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine("Results:");
            foreach (var item in namesAndGrades.OrderByDescending(x => x.Value.Max()).ThenBy(y => y.Key))
            {
                Console.WriteLine($"{item.Key} | {string.Join(" ", item.Value.Max())}");
            }
            Console.WriteLine("Submissions:");
            foreach (var item in languageAndSubmitions.OrderByDescending(y => y.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} - {string.Join(" ", item.Value.Count)}");
            }
        }
    }
}
