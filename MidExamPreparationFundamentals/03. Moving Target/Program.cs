using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Moving_Target
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();
            while (true)
            {
                string[] token = command.Split();
                if (token[0] == "Shoot")
                {
                    int index = int.Parse(token[1]);
                    int power = int.Parse(token[2]);
                    if (index >= 0 && index < targets.Count)
                    {
                        targets[index] -= power;
                        if (targets[index] <= 0)
                        {
                            targets.RemoveAt(index);
                        }
                    }

                }
                else if (token[0] == "Add")
                {
                    int index = int.Parse(token[1]);
                    int power = int.Parse(token[2]);
                    if (index >= 0 && index < targets.Count)
                    {
                        targets.Insert(index, power);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }

                }
                else if (token[0] == "Strike")
                {
                    int index = int.Parse(token[1]);
                    int radius = int.Parse(token[2]);
                    int startIndex = index - radius;
                    int endIndex = index + radius;
                    int count = endIndex - startIndex + 1;
                    if (startIndex >= 0 && endIndex < targets.Count)
                    {
                        targets.RemoveRange(startIndex, count);
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                    }

                }
                else if (token[0] == "End")
                {
                    Console.WriteLine(string.Join("|",targets));
                    break;
                }

                command = Console.ReadLine();
            }
        }
    }
}
