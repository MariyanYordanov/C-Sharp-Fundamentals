using System;
using System.Linq;

namespace _03.CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbolFirst = char.Parse(Console.ReadLine());
            char symbolSecond = char.Parse(Console.ReadLine());
            PrintAllSymbolsBetween(symbolFirst, symbolSecond);
        }

        private static void PrintAllSymbolsBetween(char symbolFirst, char symbolSecond)
        {
            char temp = symbolFirst;
            char temp2 = symbolSecond;
            if (symbolFirst < symbolSecond)
            {
                symbolSecond = temp;
                symbolFirst = temp2;
                for (char i = (char)(temp + 1); i < temp2; i++)
                {
                    Console.Write(i + " ");
                }
            }
            else
            {
                for (char i = (char)(symbolSecond + 1); i < symbolFirst; i++)
                {
                    Console.Write(i + " ");
                }
            }
            
        }

        // решението на Митко Петобоя

        //private static void PrintAllSymbolsBetween(char symbolFirst, char symbolSecond)
        //{
        //    int startChar = Math.Min(symbolFirst, symbolSecond);
        //    int endChar = Math.Max(symbolFirst, symbolSecond);

        //    for (int i = startChar + 1; i < endChar; i++)
        //    {
        //        Console.WriteLine((char)i + " ");
        //    }
        //}

    }
}
