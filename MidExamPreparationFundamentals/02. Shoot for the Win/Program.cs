using System;
using System.Linq;

namespace _02._Shoot_for_the_Win
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] target = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string shoots = Console.ReadLine();
            int count = 0;
            while (shoots != "End")
            {
                int index = int.Parse(shoots);

                if (index >= 0 && index < target.Length)
                {
                    int prevValue = target[index];
                    target[index] = -1;
                    count++;
                    for (int i = 0; i < target.Length; i++)
                    {
                        if (target[i] != target[index])
                        {
                            if (target[i] > prevValue)
                            {
                                target[i] -= prevValue;
                            }
                            else
                            {
                                target[i] += prevValue;
                            }
                        }
                        
                    }
                }
                shoots = Console.ReadLine();
            }

            Console.WriteLine($"Shot targets: {count} -> {string.Join(" ",target)}");
        }
    }
}
