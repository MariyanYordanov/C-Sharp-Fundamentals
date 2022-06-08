using System;
using System.Collections.Generic;
using System.Linq;

namespace ME._01.Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string sentence = Console.ReadLine();
            string word = " ";
            List<char> letter = new List<char>();
            for (int i = 0; i < sentence.Length; i++)
            {
                letter.Add(sentence[i]);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                int sum = 0;
                int num = arr[i];
                while (num != 0)
                {
                    sum += num % 10;
                    num /= 10;
                }
                if (sum >= letter.Count)
                {
                    int re = sum % letter.Count;
                    word += letter[re];
                    letter.RemoveAt(re);
                }
                else
                {
                    word += letter[sum];
                    letter.RemoveAt(sum);
                }

            }
            
            Console.WriteLine(word);
        }
    }
}
