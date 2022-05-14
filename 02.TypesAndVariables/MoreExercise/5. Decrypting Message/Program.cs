using System;

namespace _05._Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int lines = int.Parse(Console.ReadLine());

            char[] word = new char[lines];

            for (int i = 0; i < lines; i++)
            {
                char letterChar = char.Parse(Console.ReadLine());
                int letterInt = (int)letterChar + key;
                char letter = (char)letterInt;
                word[i] = letter;
            }
            Console.WriteLine(word);
        }
    }
}
