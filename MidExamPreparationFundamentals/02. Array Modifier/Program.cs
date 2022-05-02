using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                string[] cmd = command.Split();
                if (cmd[0] == "swap")
                {
                    int index1 = int.Parse(cmd[1]);
                    int index2 = int.Parse(cmd[2]);
                    int temp = input[index1];
                    input[index1] = input[index2];
                    input[index2] = temp;

                }
                else if (cmd[0] == "multiply")
                {
                    int index1 = int.Parse(cmd[1]);
                    int index2 = int.Parse(cmd[2]);
                    input[index1] = input[index2] * input[index1];

                }
                else if (cmd[0] == "decrease")
                {
                    for (int i = 0; i < input.Count; i++)
                    {
                        input[i] -= 1; 
                    }
                }
            }
            Console.WriteLine(string.Join(", ",input));
        }
    }
}
