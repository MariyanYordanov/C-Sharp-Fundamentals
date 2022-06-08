using System;
using System.Collections.Generic;
using System.Linq;

namespace E._02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] command = Console.ReadLine().Split();

            while (command[0] != "end")
            {
                int element = int.Parse(command[1]);
                switch (command[0])
                {
                    case "Delete":
                        list.RemoveAll(item => item == element);
                        break;
                    case "Insert":
                        int position = int.Parse(command[2]);
                        list.Insert(position, element);
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
