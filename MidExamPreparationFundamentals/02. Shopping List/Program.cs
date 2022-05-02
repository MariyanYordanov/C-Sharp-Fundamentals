using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shopingList = Console.ReadLine().Split("!").ToList();
            
            while (true)
            {
                string commands = Console.ReadLine();
                if (commands == "Go Shopping!")
                {
                    break;
                }

                string[] token = commands.Split();

                if (token[0] == "Urgent")
                {
                    string item = token[1];
                    if (!shopingList.Contains(item))
                    {
                        shopingList.Insert(0,item);
                    }
                }
                else if (token[0] == "Unnecessary")
                {
                    string item = token[1];
                    if (shopingList.Contains(item))
                    {
                        shopingList.Remove(item);
                    }
                }
                else if (token[0] == "Correct")
                {
                    string oldItem = token[1];
                    string newItem = token[2];
                    if (shopingList.Contains(oldItem))
                    {
                        int find = shopingList.IndexOf(oldItem);
                        shopingList.Insert(find, newItem);
                        shopingList.RemoveAt(find + 1);
                    }
                }
                else if (token[0] == "Rearrange")
                {
                    string item = token[1];
                    if (shopingList.Contains(item))
                    {
                        int find = shopingList.IndexOf(item);
                        shopingList.Add(item);
                        shopingList.RemoveAt(find);
                    }
                }

               
            }

            Console.WriteLine(string.Join(", ",shopingList));

        }
    }
}
