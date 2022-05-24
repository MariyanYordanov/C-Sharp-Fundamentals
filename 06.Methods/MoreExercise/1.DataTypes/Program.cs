using System;

namespace _1.DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = Console.ReadLine();

            WhatTypeIs(data);
        }

        static void WhatTypeIs(string data) 
        {
           
           if (data == "int")
           {
               int n = int.Parse(Console.ReadLine());
               Console.WriteLine(n*2);
           }
           else if (data == "real")
           {
               double n = double.Parse(Console.ReadLine());
               Console.WriteLine($"{n * 1.5:f2}");
           }
           else if (data == "string")
           {
                string data1 = Console.ReadLine();
               Console.WriteLine($"${data1}$");
           }
           
        }

    }
}
