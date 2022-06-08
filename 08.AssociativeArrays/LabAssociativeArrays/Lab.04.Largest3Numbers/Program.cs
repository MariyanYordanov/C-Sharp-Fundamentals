using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // my way
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var num = numbers.OrderByDescending(x => x).Take(3).ToList();
            Console.WriteLine(string.Join(" ",num));


            // SoftUni way
            int[] n = Console.ReadLine().Split().Select(int.Parse).OrderByDescending(n => n).ToArray();
            int count = n.Length >= 3 ? 3 : n.Length;// if (n.Length >= 3) { count = 3 } 
            //                        ^   ^
            //                        if  else             // else { count = n.Length }
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{n[i]}");
            }
        }
    }
}
