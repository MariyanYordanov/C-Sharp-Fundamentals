using System;
using System.Collections.Generic;
using System.Linq;

namespace E._02.AMinerTask
{
    class Program
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> textList = new Dictionary<string, List<int>>();

            while (true)
            {
                string inputKey = Console.ReadLine();
                if (inputKey == "stop") break;
                string inputValue = Console.ReadLine();
                if(!textList.ContainsKey(inputKey))
                {
                    textList.Add(inputKey, new List<int>());
                    textList[inputKey].Add(int.Parse(inputValue));
                }
                else
                {
                    textList[inputKey].Add(int.Parse(inputValue));
                }
            }

            foreach (var item in textList)
            {
                Console.WriteLine($"{item.Key} -> {string.Join(" ", item.Value.Sum())}");
            }
        }
    }
}
