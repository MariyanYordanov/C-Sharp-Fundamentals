using System;

namespace _01._Encrypt__Sort_and_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            int[] ordered = new int[n]; 
            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                int sum = 0;
                count++;
                for (int j = 0; j < word.Length; j++)
                {
                    char currentLetter = char.Parse(word[j].ToString());
                    int letter = (int)currentLetter;
                    if (letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U' || letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                    {
                        int lowel = letter * word.Length;
                        sum += lowel;
                    }
                    else
                    {
                        int consonant = (int)(letter / word.Length);
                        sum += consonant;
                    }
                    
                }
                ordered[i] = sum;
            }
            //Array.Sort(ordered);
            for (int i = 0; i < ordered.Length - 1; i++)
            {
                int minValue = ordered[i];
                for (int j = i + 1; j < ordered.Length; j++)
                {
                    int tempValue = ordered[j];
                    if (tempValue < minValue)
                    {
                        ordered[i] = tempValue;
                        ordered[j] = minValue;
                    }
                    minValue = ordered[i];
                }
            } 
            foreach (var item in ordered)
            {
                Console.WriteLine(item);
            }
        }
    }
}
