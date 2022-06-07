using System;
using System.Collections.Generic;
using System.Linq;

namespace ME._3.MOBAChallenger
{
    class Program
    {
        static void Main(string[] args)
        {
            var playerData = new Dictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();
            while (input != "Season end")
            {
                if (input.Contains(" -> "))
                {
                    string[] token = input.Split(" -> ");
                    string player = token[0];
                    string position = token[1];
                    int skill = int.Parse(token[2]);
                    if (!playerData.ContainsKey(player))
                    {
                        playerData.Add(player, new Dictionary<string, int>());
                    }

                    if (!playerData[player].ContainsKey(position))
                    {
                        playerData[player].Add(position, skill);
                    }

                    if (playerData[player][position] > skill)
                    {
                        playerData[player][position] = skill;
                    }

                }
                else if (input.Contains(" vs "))
                {
                    string[] players = input.Split(" vs ");
                    string firstPlayer = players[0];
                    string secondPlayer = players[1];
                    if (playerData.ContainsKey(firstPlayer))
                    {
                        bool IsPlayerExist = false;
                        foreach (var playerOne in playerData[firstPlayer].ToDictionary(x => x.Key, y => y.Value))
                        {
                            if (playerData.ContainsKey(secondPlayer))
                            {
                                foreach (var playerSecond in playerData[secondPlayer].ToDictionary(x => x.Key, y => y.Value))
                                {
                                    if (playerOne.Key == playerSecond.Key)
                                    {
                                        if (playerData[firstPlayer].Values.Sum() < playerData[secondPlayer].Values.Sum())
                                        {
                                            playerData.Remove(firstPlayer);
                                        }
                                        else if (playerData[firstPlayer].Values.Sum() > playerData[secondPlayer].Values.Sum())
                                        {
                                            playerData.Remove(secondPlayer);
                                        }
                                        else
                                        {
                                            continue;
                                        }
                                        IsPlayerExist = true;
                                        break;
                                    }

                                }

                                if (IsPlayerExist)
                                {
                                    break;
                                }
                            }
                            
                        }
                    }

                }

                input = Console.ReadLine();
            }

            foreach (var player in playerData.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{player.Key}: {player.Value.Values.Sum()} skill");
                foreach (var skill in player.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"- {skill.Key} <::> {skill.Value}");
                }
            }
        }
    }
}
