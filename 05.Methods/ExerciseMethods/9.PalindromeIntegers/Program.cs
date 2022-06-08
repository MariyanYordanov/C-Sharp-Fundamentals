using System;

namespace _009.PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input  = Console.ReadLine();

            while (input != "END")
            {
                PalindromeIntegers(input);
                input = Console.ReadLine();
            }
            
        }

        private static void PalindromeIntegers(string input)
        {
            bool isPalindrom = false;
            int length = input.Length;
            for (int i = 0; i < input.Length / 2; i++)
            {
                
                if (input[i] == input[length - 1])
                {
                    isPalindrom = true;
                }
                else
                {
                    isPalindrom = false;
                }
                length--;
            }
            if (isPalindrom)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
