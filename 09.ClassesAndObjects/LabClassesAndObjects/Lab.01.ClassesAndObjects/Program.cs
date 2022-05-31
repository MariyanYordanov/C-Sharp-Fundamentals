using System;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            Random rnd = new Random();
            
            for (int i = 0; i < words.Length - 1; i++)
            {
                int swapPosition = rnd.Next(words.Length);
                string temp = words[i];
                words[i] = words[swapPosition];
                words[swapPosition] = temp;
            }
            
            Console.WriteLine(string.Join("\n", words));
        }
    }

}
