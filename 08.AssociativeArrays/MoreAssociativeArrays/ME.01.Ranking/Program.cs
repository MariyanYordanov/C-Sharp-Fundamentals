using System;
using System.Linq;
using System.Collections.Generic;

namespace ME._01.Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> check = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> contestsData = new Dictionary<string, Dictionary<string, int>>();

            string contestPas = Console.ReadLine();
            while (contestPas != "end of contests")
            {
                string[] cmd = contestPas.Split(":");
                string contestCheck = cmd[0];
                string passwordCheck = cmd[1];
                if (!check.ContainsKey(contestCheck))
                {
                    check.Add(contestCheck, passwordCheck);
                }

                contestPas = Console.ReadLine();
            }
            string input = Console.ReadLine();
            while (input != "end of submissions")
            {
                string[] cmd = input.Split("=>");
                string contest = cmd[0];
                string password = cmd[1];
                string username = cmd[2];
                int points = int.Parse(cmd[3]);
                if (check.Any(x => x.Key == contest && x.Value == password))
                {
                    if (!contestsData.ContainsKey(username))
                    {
                        contestsData.Add(username, new Dictionary<string, int>());
                        contestsData[username].Add(contest, points);
                    }

                    if (!contestsData[username].ContainsKey(contest))
                    {
                        contestsData[username].Add(contest, points);
                    }

                    if (contestsData[username][contest] < points)
                    {
                        contestsData[username][contest] = points;
                    }
                }

                input = Console.ReadLine();
            }
            string bestUser = "";
            int bestUserScore = 0;
            foreach (var user in contestsData)
            {
                foreach (var contest in contestsData.Values)
                {
                    int sum = 0;
                    foreach (var item in contest.Values)
                    {
                        sum += item;
                    }

                    if (sum > bestUserScore)
                    {
                        bestUserScore = sum;
                        bestUser = user.Key;
                    }

                }

            }

            Console.WriteLine($"Best candidate is {bestUser} with total {bestUserScore} points.");
            Console.WriteLine($"Ranking: ");
            foreach (var user in contestsData.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{user.Key}");
                foreach (var contest in user.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }

            }

        }
    }
}

