using System;
using System.Collections.Generic;
using System.Linq;

namespace ME._05.DrumSet
{
    class Program
    {
        static void Main(string[] args)
        {
            double saving = double.Parse(Console.ReadLine());
            List<int> quantity = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> start = new List<int>();
            for (int i = 0; i < quantity.Count; i++)
            {
                start.Add(quantity[i]);
            }
            string command = Console.ReadLine();
            while (command != "Hit it again, Gabsy!")
            {
                int hitPower = int.Parse(command);
                for (int i = 0; i < quantity.Count; i++)
                {
                    if (quantity[i] > 0)
                    {
                        quantity[i] -= hitPower;

                        if (quantity[i] <= 0)
                        {
                            if (saving < start[i] * 3)
                            {
                                quantity.RemoveAt(i);
                                start.RemoveAt(i);
                                i--;
                            }
                            else
                            {
                                quantity[i] = start[i];
                                saving -= start[i] * 3;
                            }

                        }

                    }
                    
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", quantity));
            Console.WriteLine($"Gabsy has {saving:f2}lv.");
        }
    }
}
