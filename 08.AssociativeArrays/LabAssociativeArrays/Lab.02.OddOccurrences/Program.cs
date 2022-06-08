using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab._02.OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            Dictionary<string, int> counts = new Dictionary<string, int>();
            foreach(string word in words)
            {
                string wordCaseSensitive = word.ToLower();
                if (counts.ContainsKey(wordCaseSensitive))
                {
                    counts[wordCaseSensitive]++;
                }
                else
                {
                    counts.Add(wordCaseSensitive, 1);
                }
                
            }
            foreach (var count in counts)
            {
                if (count.Value % 2 != 0)
                {
                    Console.Write(count.Key + " ");
                }
               
            }
            
        }
    }
}
