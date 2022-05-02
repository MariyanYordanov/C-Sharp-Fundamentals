using System;
using System.Collections.Generic;
using System.Linq;

namespace E._2._3.PlantDiscovery
{
    class Program
    {
        class Plants
        {
            
            public int Rarity { get; set; }
            public double Average { get; set; }
            public List<int> RatingList { get; set; }

        }
        static void Main(string[] args)
        {
            Dictionary<string, Plants> plantColection = new Dictionary<string, Plants>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] plantsData = Console.ReadLine().Split("<->");
                string plantName = plantsData[0];
                int rarity = int.Parse(plantsData[1]);
                double average = 0;
                if (!plantColection.ContainsKey(plantName))
                {
                    Plants plant = new Plants()
                    {
                        Rarity = rarity,
                        RatingList = new List<int>(),
                        Average = average,
                    };

                    plantColection.Add(plantName, plant); 
                }
                else if (plantColection.ContainsKey(plantName))
                {
                    plantColection[plantName].Rarity = rarity; 
                }
            }

            string commands = Console.ReadLine();
            while (commands != "Exhibition")
            {
                string[] cmd = commands.Split();
                string leedCommand = cmd[0];
                string plant = cmd[1];
                if (!plantColection.ContainsKey(plant))
                {
                    Console.WriteLine("error");
                }
                else
                {
                    if (leedCommand == "Rate:")
                    {
                        int rating = int.Parse(cmd[3]);
                        plantColection[plant].RatingList.Add(rating);
                    }
                    else if (leedCommand == "Update:")
                    {
                        int newRarity = int.Parse(cmd[3]);
                        plantColection[plant].Rarity = newRarity;
                    }
                    else if (leedCommand == "Reset:")
                    {
                        plantColection[plant].RatingList.Clear();
                    }
                }
                
                commands = Console.ReadLine();
            }

            var colection = plantColection.OrderByDescending(plant => plant.Value.Rarity);
            Console.WriteLine("Plants for the exhibition:");
            
            foreach (var plant in colection)
            {
                plant.Value.Average = Average(plant.Value.RatingList.Sum(), plant.Value.RatingList.Count); 
            }

            foreach (var item in colection.ThenByDescending(x => x.Value.Average))
            {
                Console.WriteLine($"- {item.Key}; Rarity: {item.Value.Rarity}; Rating: {item.Value.Average:f2}");
            }

        }

        private static double Average(int sum, int count)
        {
            double average = 0;
            if (count > 0)
            {
                average = (double)sum / count;
            }
            else
            {
                average = 0;
            }
            return average;
        }
    }
}
