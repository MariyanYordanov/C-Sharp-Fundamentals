using System;
using System.Collections.Generic;
using System.Linq;

namespace E._05.TeamworkProjects
{
    class Program
    {
        class Team
        {
            public string Name { get; set; }
            public string Creator { get; set; }
            public List<string> Members { get; set; }

        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split("-");
                var teamCreator = input[0];
                var teamName = input[1];
                if (teams.Any(team => team.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (teams.Any(team => team.Creator == teamCreator))
                {
                    Console.WriteLine($"{teamCreator} cannot create another team!");
                }
                else
                {
                    var team = new Team();
                    team.Name = teamName;
                    team.Creator = teamCreator;
                    team.Members = new List<string>();
                    teams.Add(team);
                    Console.WriteLine($"Team {teamName} has been created by {teamCreator}!");
                }
                
            }

            var command = Console.ReadLine();
            while (command != "end of assignment")
            {
                
                var user = command.Split(new string[] {"->"},StringSplitOptions.None)[0];
                var desiredTeam = command.Split(new string[] {"->"},StringSplitOptions.None)[1];
                
                
                if (!teams.Any(team => team.Name == desiredTeam))
                {
                    Console.WriteLine($"Team {desiredTeam} does not exist!");
                }
                else if (teams.Any(team => team.Members.Contains(user) || teams.Any(team => team.Creator == user)))
                {
                    Console.WriteLine($"Member {user} cannot join team {desiredTeam}!");
                }
                else
                {
                    var currentTeam = teams.First(team => team.Name == desiredTeam);
                    currentTeam.Members.Add(user);
                }
                command = Console.ReadLine();
            }
            var finalTeam = teams.Where(team => team.Members.Count > 0);
            var disbandTeams = teams.Where(team => team.Members.Count == 0);
            foreach (Team team in finalTeam.OrderByDescending(team => team.Members.Count).ThenBy(team => team.Name))
            {
                Console.WriteLine($"{team.Name}");
                Console.WriteLine($"- {team.Creator}");
               
                foreach (string member in team.Members.OrderBy(member => member))
                {
                    Console.WriteLine($"-- {member}");
                }
            }
            Console.WriteLine($"Teams to disband:");
            if (disbandTeams != null)
            {
                foreach (Team disbandTeam in disbandTeams.OrderBy(team => team.Name))
                {
                    Console.WriteLine($"{disbandTeam.Name}");
                }
            }
        }
    }
}
