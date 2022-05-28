using System;
using System.Collections.Generic;
using System.Linq;

namespace E._03.HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> list = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string[] name = Console.ReadLine().Split();
                
                if (name[2] == "going!")
                {
                    if (list.Contains(name[0]))
                    {
                        Console.WriteLine($"{name[0]} is already in the list!");
                    }
                    else
                    {
                        list.Add(name[0]);
                    }
                    
                }

                else if (name[2] == "not")
                {
                    if (list.Contains(name[0]))
                    {
                        list.RemoveAll(x => x == name[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{name[0]} is not in the list!");
                    }
                    
                }

            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
