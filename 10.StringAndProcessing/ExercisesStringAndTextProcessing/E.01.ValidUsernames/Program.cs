using System;

namespace E._01.ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            foreach (var word in input)
            {
                if (word.Length > 3 && word.Length <= 16)
                {
                    bool isLeterOrDigitOrHyphensOrUnderscore = true;
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (!(word[i] == '-' || word[i] == '_' || char.IsLetterOrDigit(word[i])))
                        {
                            isLeterOrDigitOrHyphensOrUnderscore = false;
                            break;
                        }

                    }

                    if (isLeterOrDigitOrHyphensOrUnderscore)
                    {
                        Console.WriteLine(word);
                    }

                }
            }
        }
    }
}
