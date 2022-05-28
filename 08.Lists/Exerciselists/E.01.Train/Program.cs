using System;
using System.Collections.Generic;
using System.Linq;

namespace E._01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagon = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapasity = int.Parse(Console.ReadLine());
            string[] command = Console.ReadLine().Split();

            while (command[0] != "end")
            {
                if (command[0] == "Add")
                {
                    int number = int.Parse(command[1]);
                    wagon.Add(number);
                }

                else
                {
                    int number = int.Parse(command[0]);
                    for (int i = 0; i < wagon.Count; i++)
                    {
                        if (wagon[i] + number <= maxCapasity)
                        {
                            wagon[i] = wagon[i] + number;
                            break;
                        }
                    }
                }

                command = Console.ReadLine().Split();
            }
            foreach (var item in wagon)
            {
                Console.Write(item + " ");
            }
        }
    }
}
