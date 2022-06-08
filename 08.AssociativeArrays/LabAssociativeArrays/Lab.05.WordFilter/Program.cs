using System;
using System.Linq;

namespace Lab._05.WordFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] wordsArray = Console.ReadLine().Split();
            foreach (string word in wordsArray.Where(x => x.Length % 2 == 0))
            {
                Console.WriteLine(word);
            }
        }
    }
}
