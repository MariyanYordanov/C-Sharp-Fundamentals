using System;
using System.Collections.Generic;

namespace ME._03.TakeSkipRope
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            List<int> digits = new List<int>();
            List<char> letters = new List<char>();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 48 && str[i] <= 57)
                {
                    int realDigit = str[i] - 48;
                    digits.Add(realDigit);
                }
                else
                {
                    letters.Add(str[i]);
                }
            }
            List<int> take = new List<int>();
            List<int> skip = new List<int>();
            for (int i = 0; i < digits.Count; i++)
            {
                if (i % 2 == 0)
                {
                    take.Add(digits[i]);
                }
                else
                {
                    skip.Add(digits[i]);
                }
            }

            List<char> decrypted = new List<char>();

            for (int i = 0; i < take.Count; i++)
            {
                if (take[i] > letters.Count)
                {
                    take[i] = letters.Count;
                }

                if (take[i] > 0)
                {
                    for (int j = 0; j < take[i]; j++)
                    {
                        decrypted.Add(letters[0]);
                        letters.RemoveAt(0);
                    }
                }
                
                if (skip[i] > letters.Count)
                {
                    skip[i] = letters.Count;
                }

                letters.RemoveRange(0,skip[i]);

            }

            Console.WriteLine(string.Join("", decrypted));
        }
    }
}
