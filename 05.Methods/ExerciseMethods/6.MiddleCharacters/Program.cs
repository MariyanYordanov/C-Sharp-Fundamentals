using System;

namespace _006.MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            FindMiddleCharacter(input);
        }
        
        private static void FindMiddleCharacter(string input)
        {
            if (input.Length % 2 == 0)
            {
                Console.Write(input[(input.Length - 1) / 2]);
                Console.Write(input[((input.Length - 1)/ 2) + 1]);
            }
            else
            {
                Console.WriteLine(input[input.Length / 2]);
            }
            
        }
    }
}
