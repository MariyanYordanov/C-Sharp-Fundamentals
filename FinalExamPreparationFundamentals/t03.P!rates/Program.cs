using System;
using System.Collections.Generic;
using System.Linq;

namespace t03.P_rates
{
    class Program
    {
        class City
        {
            public int Population { get; set; }
            public int Gold { get; set; }
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, City> cityData = new Dictionary<string, City>();
            while (input != "Sail")
            {
                string[] cities = input.Split("||");
                string town = cities[0];
                int population = int.Parse(cities[1]);
                int gold = int.Parse(cities[2]);
                if (!cityData.ContainsKey(town))
                {
                    cityData.Add(town, new City()
                    {
                        Population = population,
                        Gold = gold
                    });
                }
                else
                {
                    cityData[town].Population += population;
                    cityData[town].Gold += gold;
                }

                input = Console.ReadLine();
            }

            string commands = Console.ReadLine();
            while (commands != "End")
            {
                string[] token = commands.Split("=>");
                string cmd = token[0];
                if (cmd == "Plunder")
                {
                    string town = token[1];
                    int people = int.Parse(token[2]);
                    int gold = int.Parse(token[3]);
                    if (cityData.ContainsKey(town))
                    {
                        cityData[town].Population -= people;
                        cityData[town].Gold -= gold;
                        Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");
                    }

                    if (cityData[town].Population <=0 || cityData[town].Gold <= 0)
                    {
                        cityData.Remove(town);
                        Console.WriteLine($"{town} has been wiped off the map!");
                    }
                }

                else if (cmd == "Prosper")
                {
                    string town = token[1];
                    int gold = int.Parse(token[2]);
                    if (gold < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }
                    else
                    {
                        cityData[town].Gold += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {cityData[town].Gold} gold.");
                    }
                }
                commands = Console.ReadLine();
            }

            var listSotred = cityData.OrderByDescending(x => x.Value.Gold).ThenBy(x => x.Key);
            if (listSotred.Any())
            {
                Console.WriteLine($"Ahoy, Captain! There are {listSotred.Count()} wealthy settlements to go to:"); 
                foreach (var item in listSotred)
                {
                    Console.WriteLine($"{item.Key} -> Population: {item.Value.Population} citizens, Gold: {item.Value.Gold} kg");
                }
            }
            
        }
    }
}
