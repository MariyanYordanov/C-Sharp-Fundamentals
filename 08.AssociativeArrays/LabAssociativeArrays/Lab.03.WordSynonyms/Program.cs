using System;
using System.Collections.Generic;

namespace Lab._03.WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> WORDS = new Dictionary<string, List<string>>();
            for (int i = 0; i < n; i++)
            {
                string wordKey = Console.ReadLine();
                string wordValue = Console.ReadLine();
                if (!WORDS.ContainsKey(wordKey))
                {
                    WORDS.Add(wordKey, new List<string>());
                }

                WORDS[wordKey].Add(wordValue);
            }
            foreach (var item in WORDS)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }
        }
    }
}
