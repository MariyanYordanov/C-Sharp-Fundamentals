using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam.Task._3.Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> wordsDefinitions = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();
            string[] allWordsAndDefinitions = input.Split(" | ");
            for (int i = 0; i < allWordsAndDefinitions.Length; i++)
            {
                string eachOneWordAndDefinition = allWordsAndDefinitions[i];
                string[] wordsDefinition = eachOneWordAndDefinition.Split(": ");
                string word = wordsDefinition[0];
                string definition = wordsDefinition[1];
                if (!wordsDefinitions.ContainsKey(word))
                {
                    wordsDefinitions.Add(word, new List<string>());
                    wordsDefinitions[word].Add(definition);
                }

                if (wordsDefinitions.ContainsKey(word) && wordsDefinitions[word][0] != definition)
                {
                    wordsDefinitions[word].Add(definition);
                }

            }

            string words = Console.ReadLine();
            string[] token = words.Split(" | ");
            string command = Console.ReadLine();
            if (command == "Test")
            {
                for (int j = 0; j < token.Length; j++)
                {
                    if (wordsDefinitions.ContainsKey(token[j]))
                    {
                        Console.WriteLine($"{token[j]}:");
                        foreach (var definitions in wordsDefinitions)
                        {
                            if (definitions.Key == token[j])
                            {
                                foreach (var item in definitions.Value.OrderByDescending(x => x.Length))
                                {
                                    Console.WriteLine($" -{item}");
                                }

                            }
                            
                        }

                    }

                }

            }
            else if (command == "Hand Over")
            {
                foreach (var word in wordsDefinitions.OrderBy(x => x.Key))
                {
                    Console.Write($"{word.Key} ");
                }

            }
        }
    }
}
