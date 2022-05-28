using System;
using System.Collections.Generic;
using System.Linq;

namespace E._04.ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] command = Console.ReadLine().Split();

            while (command[0] != "End")
            {
                if (command[0] == "Add")
                {
                    int number = int.Parse(command[1]);
                    list.Add(number);
                }

                if (command[0] == "Insert")
                {
                    int number = int.Parse(command[1]);
                    int index = int.Parse(command[2]);
                    if (index >= list.Count || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        list.Insert(index, number);
                    }
                    
                }

                if (command[0] == "Remove")
                {
                    int index = int.Parse(command[1]);
                    if (index >= list.Count || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        list.RemoveAt(index);
                    }
                    
                }

                switch (command[1])
                {
                    case "right":
                        int count = int.Parse(command[2]);
                        for (int i = 0; i < count; i++)
                        {
                            list.Insert(0,list[list.Count - 1]);
                            list.RemoveAt(list.Count - 1);
                        }
                        break;
                    case "left":
                        int count1 = int.Parse(command[2]);
                        for (int i = 0; i < count1; i++)
                        {
                            list.Add(list[0]);
                            list.RemoveAt(0);
                        }
                        break;
                }

                command = Console.ReadLine().Split();

            }

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
        }
    }
}
