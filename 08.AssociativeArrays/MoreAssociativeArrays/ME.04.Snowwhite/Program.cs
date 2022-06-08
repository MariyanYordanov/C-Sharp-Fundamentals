using System;
using System.Collections.Generic;
using System.Linq;

namespace ME._04.Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> dwarf = new Dictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();
            while (input != "Once upon a time")
            {
                string[] data = input.Split(" <:> ",StringSplitOptions.RemoveEmptyEntries);
                string name = data[0];
                string hat = data[1];
                int physics = int.Parse(data[2]);
                if (!dwarf.ContainsKey(hat))
                {
                    dwarf.Add(hat, new Dictionary<string, int>());
                }
                
                if (!dwarf[hat].ContainsKey(name))
                {
                    dwarf[hat].Add(name, physics);
                }

                if (dwarf[hat][name] < physics)
                {
                    dwarf[hat][name] = physics;
                }

                input = Console.ReadLine();
            }

            foreach (var item in dwarf.OrderByDescending(x => x.Value.Values.Max()).ThenByDescending(x => x.Value.Keys.Count))
            {
                foreach (var name in item.Value)
                {
                    Console.WriteLine($"({item.Key}) {name.Key} <-> {name.Value}");
                }
            }
        }
    }
}
