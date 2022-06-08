using System;

namespace Lab._05.Digits_LettersAndOther
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            char[] input = text.ToCharArray();
            string nums = "";
            string symbol = "";
            string letter = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsDigit(input[i]) ==true)
                {
                    nums += input[i];
                }
                else if (Char.IsLetter(input[i]) == true)
                {
                    letter += input[i];
                }
                else
                {
                    symbol += input[i];
                }
            }
            Console.WriteLine(nums);
            Console.WriteLine(letter);
            Console.WriteLine(symbol);
        }
    }
}
