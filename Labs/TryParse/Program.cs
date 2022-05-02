using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string dataType = " ";
            int n;
            float f;
            char ch;
            bool b;

            while (input != "END")
            {
                if (int.TryParse(input,out n))
                {
                    dataType = "integer";
                    Console.WriteLine($"{input} is {dataType} type");
                }
                else if (float.TryParse(input, out f))
                {
                    dataType = "floating point";
                    Console.WriteLine($"{input} is {dataType} type");
                }
                else if (char.TryParse(input, out ch))
                {
                    dataType = "character";
                    Console.WriteLine($"{input} is {dataType} type");
                }
                else if (bool.TryParse(input, out b))
                {
                    dataType = "boolean";
                    Console.WriteLine($"{input} is {dataType} type");
                }
                else
                {
                    dataType = "string";
                    Console.WriteLine($"{input} is {dataType} type");
                }
                input = Console.ReadLine();
            }
        }
    }
}
