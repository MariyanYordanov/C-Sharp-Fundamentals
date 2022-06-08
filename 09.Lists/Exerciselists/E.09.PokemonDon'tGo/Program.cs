using System;
using System.Collections.Generic;
using System.Linq;

namespace E._09.PokemonDon_tGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            int sum = 0;
            int currentValue = 0;
            int index = 0;
            while (list.Count != 0)
            {
                index = int.Parse(Console.ReadLine());
                
                if (index > list.Count - 1)
                {
                    currentValue = list[list.Count - 1];
                    sum += currentValue;
                    list[list.Count - 1] = list[0];
                }

                else if (index < 0)
                {
                    currentValue = list[0];
                    sum += currentValue;
                    list[0] = list[list.Count - 1];
                }
                else
                {
                    currentValue = list[index];
                    sum += currentValue;
                    list.RemoveAt(index);
                }

                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] <= currentValue)
                    {
                        list[i] += currentValue;
                    }
                    else
                    {
                        list[i] -= currentValue;
                    }

                }

            }

            Console.WriteLine(sum);
        }
    }
}
