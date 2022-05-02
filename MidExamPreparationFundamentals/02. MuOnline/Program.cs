using System;
using System.Linq;

namespace _02._MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rooms = Console.ReadLine().Split("|");
            int bitcoins = 0;
            int health = 100;
            int room = 0;
            for (int i = 0; i < rooms.Length; i++)
            {
                string[] commands = rooms[i].Split().ToArray();
                if (commands[0] == "potion")
                {
                    int reHealthed = int.Parse(commands[1]);
                    int currentHeaith = health;
                    health += reHealthed;
                    if (health > 100)
                    {
                        health = 100;
                    }
                    int amount = health - currentHeaith; 
                    Console.WriteLine($"You healed for {amount} hp.");
                    Console.WriteLine($"Current health: {health} hp.");
                    room++;
                }
                else if (commands[0] == "chest")
                {
                    int findBitcoins = int.Parse(commands[1]);
                    bitcoins += findBitcoins;
                    Console.WriteLine($"You found {findBitcoins} bitcoins.");
                    room++;
                }
                else 
                {
                    string monster = commands[0];
                    int attackOfMonster = int.Parse(commands[1]);
                    health -= attackOfMonster;
                    room++;
                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {monster}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {monster}.");
                        Console.WriteLine($"Best room: {room}");
                        return;
                    }
                }

            }
            Console.WriteLine($"You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoins}");
            Console.WriteLine($"Health: {health}");
        }
    }
}
