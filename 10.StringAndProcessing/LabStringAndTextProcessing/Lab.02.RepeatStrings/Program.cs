using System;
using System.Text;
namespace Lab._02.RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            StringBuilder sb = new StringBuilder();
            foreach (string word in arr)
            {
                int counter = word.Length;
                for (int i = 0; i < counter; i++)
                {
                    sb.Append(word);
                }
            }

            Console.WriteLine(sb);
        }
    }
}
