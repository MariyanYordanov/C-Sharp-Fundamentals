using System;
using System.Text;

namespace E._04.CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder caesarCipher = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                char newChar = (char)(input[i] + 3);
                caesarCipher.Append(newChar);
            }
            Console.WriteLine(caesarCipher);
        }
    }
}
