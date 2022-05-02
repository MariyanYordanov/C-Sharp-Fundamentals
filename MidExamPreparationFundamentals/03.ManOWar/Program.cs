using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ManOWar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pirateShip = Console.ReadLine().Split(">",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList(); 
            List<int> warShip = Console.ReadLine().Split(">", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int healthMax = int.Parse(Console.ReadLine());
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Retire")
                {
                    break;
                }
                string[] token = input.Split();
                string command = token[0];
                if (command == "Fire")
                {
                    int index = int.Parse(token[1]);
                    int damage = int.Parse(token[2]);
                    if (index >= 0 && index < warShip.Count)
                    {
                        warShip[index] -= damage;
                        if (warShip[index] <= 0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            return;
                        }
                    }
                }
                else if (command == "Defend")
                {
                    int startIndex = int.Parse(token[1]);
                    int endIndex = int.Parse(token[2]);
                    int damage = int.Parse(token[3]);
                    if ((startIndex >= 0 && startIndex < pirateShip.Count) && (endIndex >= 0 && endIndex < pirateShip.Count))
                    {
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            pirateShip[i] -= damage;
                            if (pirateShip[i] <= 0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                return;
                            }

                        }
                        
                    }
                }
                else if (command == "Repair")
                {
                    int index = int.Parse(token[1]);
                    int health = int.Parse(token[2]);
                    if (index >=0 && index < pirateShip.Count)
                    {
                        pirateShip[index] += health;
                        if (pirateShip[index] > healthMax)
                        {
                            pirateShip[index] = healthMax;
                        }
                    }
                }
                else if (command == "Status")
                {
                    int count = 0;
                    for (int i = 0; i < pirateShip.Count; i++)
                    {
                        if (pirateShip[i] < (healthMax * 0.2))
                        {
                            count++;
                            
                        }
                    }
                    Console.WriteLine($"{count} sections need repair.");
                }
            }
            int pirateShipSum = pirateShip.Sum();
            int warshipSum = warShip.Sum();
            if (true)
            {
                Console.WriteLine($"Pirate ship status: {pirateShipSum}");
                Console.WriteLine($"Warship status: {warshipSum}");
            }
        }
    }
}
