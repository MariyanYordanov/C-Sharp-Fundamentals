using System;
using System.Text.RegularExpressions;

namespace Lab._01.MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string names = Console.ReadLine();
            Regex regex = new Regex(@"\b[A-Z][a-z]+ [A-Z][a-z]+");
            MatchCollection matchedNames = regex.Matches(names);
            foreach (Match name in matchedNames)
            {
                Console.Write($"{name.Value}" );
            }
            Console.WriteLine();
        }
    }
}
