using System;
using System.Linq;

namespace _004._Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string item = Console.ReadLine();
            string meti = new string(item.ToCharArray().Reverse().ToArray());

            Console.WriteLine(meti);
        }
    }
}
