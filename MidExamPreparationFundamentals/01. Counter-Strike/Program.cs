using System;

namespace _01._Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int count = 0;
            while (input != "End of battle")
            {
                int distance = int.Parse(input);
                
                if (energy >= distance)
                {
                    count++;
                    energy -= distance;
                    if (count % 3 == 0)
                    {
                        energy += count;
                    }

                }


                else if (energy < distance)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {count} won battles and {energy} energy");
                    return;
                }

                input = Console.ReadLine();
            }
            if (energy >= 0)
            {
                Console.WriteLine($"Won battles: {count}. Energy left: {energy}");
            }
        }
    }
}
