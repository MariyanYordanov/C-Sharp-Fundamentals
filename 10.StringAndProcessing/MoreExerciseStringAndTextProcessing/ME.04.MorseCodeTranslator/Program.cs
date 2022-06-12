using System;
using System.Collections.Generic;

namespace ME._04.MorseCodeTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            Dictionary<string, char> morseCode = new Dictionary<string, char>()
            {
                { "|", ' ' },
                {".-", 'A'},
                {"-...", 'B'},
                {"-.-.", 'C'},
                {"-..", 'D'},
                {".", 'E'},
                {"..-.", 'F'},
                {"--.", 'G'},
                {"....", 'H'},
                {"..", 'I'},
                {".---", 'J'},
                {"-.-", 'K'},
                {".-..", 'L'},
                {"--", 'M'},
                {"-.", 'N'},
                {"---", 'O'},
                {".--.", 'P'},
                {"--.-", 'Q'},
                {".-.", 'R'},
                {"...", 'S'},
                {"-", 'T'},
                {"..-", 'U'},
                {"...-", 'V'},
                {".--", 'W'},
                {"-..-", 'X'},
                {"-.--", 'Y'},
                {"--..", 'Z'},
                
            };
            string[] letter = message.Split();
            for (int i = 0; i < letter.Length; i++)
            {
                foreach (var item in morseCode)
                {
                    if (item.Key == letter[i])
                    {
                        Console.Write($"{item.Value}");
                        break;
                    }
                }
                
            }

        }
    }
}
