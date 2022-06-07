using System;
using System.Linq;
using System.Collections.Generic;

namespace ME._02.Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            var contestsData = new Dictionary<string, Dictionary<string, int>>();
            var namePoints = new Dictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();
            while (input != "no more time")
            {
                string[] cmd = input.Split(" -> ");
                string username = cmd[0];
                string contest = cmd[1];
                int points = int.Parse(cmd[2]);
                if (!contestsData.ContainsKey(contest))
                {
                    contestsData.Add(contest, new Dictionary<string, int>());
                }

                if (!contestsData[contest].ContainsKey(username))
                {
                    contestsData[contest].Add(username, points);
                }

                if (contestsData[contest][username] < points)
                {
                    contestsData[contest][username] = points;
                }

                if (!namePoints.ContainsKey(username))
                {
                    namePoints.Add(username,new Dictionary<string, int>());
                }

                if (!namePoints[username].ContainsKey(contest))
                {
                    namePoints[username].Add(contest, points);
                }

                if (namePoints[username][contest] < points)
                {
                    namePoints[username][contest] = points;
                }

                input = Console.ReadLine();
            }

            
            foreach (var contest in contestsData)
            {
                Console.WriteLine($"{contest.Key}: {contest.Value.Count} participants");
                int counter = 1;
                foreach (var user in contest.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{counter}. {user.Key} <::> {user.Value}");
                    counter++;
                }
            }

            int count = 1;
            Console.WriteLine("Individual standings:");
            foreach (var user in namePoints.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{count}. {user.Key} -> {user.Value.Values.Sum()}");
                count++;
            }
        }   
    }
}
