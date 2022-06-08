using System;
using System.Collections.Generic;
using System.Linq;

namespace E._03.LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> legendaryItems = new Dictionary<string, int>();
            SortedDictionary<string, int> junk = new SortedDictionary<string, int>();

            legendaryItems.Add("shards", 0);
            legendaryItems.Add("fragments", 0);
            legendaryItems.Add("motes", 0);
            string winner = "";
            bool isTrue = false;
            while (true)
            {
                string[] input = Console.ReadLine().Split();
                for (int i = 0; i <= input.Length - 1; i++)
                {
                    if (i % 2 == 0)
                    {
                        int quantity = int.Parse(input[i]);
                        string material = (input[i + 1]).ToLower();
                        if (material == "shards")
                        {
                            legendaryItems["shards"] += quantity;
                            winner = "Shadowmourne";
                            if (legendaryItems["shards"] >= 250) 
                            {
                                legendaryItems["shards"]-= 250;
                                isTrue = true;
                                break;
                            }
                            
                        }
                        else if (material == "fragments")
                        {
                            legendaryItems["fragments"] += quantity;
                            winner = "Valanyr";
                            if (legendaryItems["fragments"] >= 250)
                            {
                                legendaryItems["fragments"] -= 250;
                                isTrue = true;
                                break;
                            }

                        }
                        else if (material == "motes")
                        {
                            legendaryItems["motes"] += quantity;
                            winner = "Dragonwrath";
                            if (legendaryItems["motes"] >= 250)
                            {
                                legendaryItems["motes"] -= 250;
                                isTrue = true;
                                break;
                            }

                        }
                        else
                        {
                            if (!junk.ContainsKey(material))
                            {
                                junk.Add(material, 0);
                            }

                            junk[material] += quantity;
                        }
                    }
                }
                if (isTrue)
                {
                    break;
                }
            }
            Console.WriteLine($"{winner} obtained!");
            foreach (var item in legendaryItems.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (var item in junk)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
