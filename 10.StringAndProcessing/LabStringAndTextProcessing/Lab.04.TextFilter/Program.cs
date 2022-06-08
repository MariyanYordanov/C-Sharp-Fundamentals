using System;

namespace Lab._04.TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ");
            string input = Console.ReadLine();
            string text = input;
            foreach (string word in bannedWords)
            {
                string astarsks = new string('*', word.Length);
                if (text.Contains(word))
                {
                    text = text.Replace(word, astarsks);
                }
            }
            Console.WriteLine(text);
        }
    }
}
