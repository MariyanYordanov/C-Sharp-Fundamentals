using System;
using System.Collections.Generic;
using System.Linq;

namespace E._01.CountCharInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] letters = Console.ReadLine().ToCharArray();
            Dictionary<char, int> textList = new Dictionary<char, int>();
            for (int i = 0; i < letters.Length; i++)
            {
                if (letters[i] != ' ')
                {
                    if (!textList.ContainsKey(letters[i]))
                    {
                        textList.Add(letters[i], 0);
                    }
                    textList[letters[i]]++;
                }
                
            }
            
            foreach (var letter in textList)
            {
                Console.WriteLine($"{letter.Key} -> {letter.Value}");
            }
        }
    }
}
