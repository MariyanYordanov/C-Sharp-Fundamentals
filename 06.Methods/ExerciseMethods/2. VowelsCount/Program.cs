using System;
using System.Linq;

namespace _02._VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            Console.WriteLine(VowelsCount(text));
        }

        private static int VowelsCount(string text)
        {
            int count = 0;
            foreach (char vowels in text)
            {
                if ("aeiou".Contains(vowels))
                {
                    count++;
                }
            }
            return count;
        }

        // решение на един ред 

        //private static int VowelsCount(string text)
        //{
        //    Console.WriteLine(text.Count(vowles => "aeiou".Contains(vowles)));
        //}
    }
}
