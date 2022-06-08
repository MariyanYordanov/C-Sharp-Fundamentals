using System;

namespace Lab._01.Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            while (word != "end")
            {
                string reverced = "";
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    reverced += word[i];
                }

                Console.WriteLine($"{word} = {reverced}");
                word = Console.ReadLine();
            }
        }
    }
}
