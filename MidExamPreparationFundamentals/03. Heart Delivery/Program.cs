using System;
using System.Linq;

namespace _03._Heart_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] neighborhood = Console.ReadLine().Split("@").Select(int.Parse).ToArray();
            string commands = Console.ReadLine();
            int lastIndex = 0;
            while (commands != "Love!")
            {
                string[] token = commands.Split();

                if (token[0] == "Jump")
                {
                    int houseIndex = int.Parse(token[1]) + lastIndex;
                    if (houseIndex < 0 || houseIndex > neighborhood.Length - 1)
                    {
                        houseIndex = 0;
                        lastIndex = houseIndex;
                    }
                    if (neighborhood[houseIndex] == 0)
                    {
                        lastIndex = houseIndex;
                        Console.WriteLine($"Place {houseIndex} already had Valentine's day.");

                    }
                    else
                    {
                        neighborhood[houseIndex] -= 2;
                        lastIndex = houseIndex;
                        if (neighborhood[houseIndex] == 0)
                        {
                            Console.WriteLine($"Place {houseIndex} has Valentine's day.");
                        }
                    }

                    commands = Console.ReadLine();
                }
            }
            Console.WriteLine($"Cupid's last position was {lastIndex}.");
            int houseCount = 0;
            for (int i = 0; i < neighborhood.Length; i++)
            {
                if (neighborhood[i] > 0)
                {
                    houseCount++;
                }
                
            }
            if (houseCount == 0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {houseCount} places.");
            }
        }
    }
}
