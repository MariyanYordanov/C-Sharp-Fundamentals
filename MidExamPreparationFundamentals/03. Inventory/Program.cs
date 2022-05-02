using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inventory = Console.ReadLine().Split(", ").ToList();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Craft!")
                {
                    break;
                }

                string[] cmd = command.Split(" - ");
                if (cmd[0] == "Collect")
                {
                    string item = cmd[1];
                    if (!inventory.Contains(item))
                    {
                        inventory.Add(item);
                    }

                }
                else if (cmd[0] == "Drop")
                {
                    string item = cmd[1];
                    if (inventory.Contains(item))
                    {
                        inventory.Remove(item);
                    }

                }
                else if (cmd[0] == "Combine Items")
                {
                    string[] token = cmd[1].Split(":");
                    string oldItem = token[0];
                    string newItem = token[1];
                    if (inventory.Contains(oldItem))
                    {
                        int oldIndex = inventory.IndexOf(oldItem);
                        inventory.Insert(oldIndex + 1,newItem);
                    }
                }
                else if (cmd[0] == "Renew")
                {
                    string item = cmd[1];
                    if (inventory.Contains(item))
                    {
                        inventory.Add(item);
                        inventory.Remove(item);
                    }
                }

            }

            Console.WriteLine(string.Join(", ", inventory));
        }
    }
}
