using System;
using System.Linq;
using System.Collections.Generic;

namespace E._08.AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split().ToList();
            

            while (true)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "3:1")
                {
                    break;
                }

                int startIndex = int.Parse(command[1]);
                int endIndex = int.Parse(command[2]);
                string concat = "";

                if (endIndex > list.Count - 1 || endIndex < 0)
                {
                    endIndex = list.Count - 1;
                }

                if (startIndex < 0 || startIndex > list.Count - 1)
                {
                    startIndex = 0;
                }

                if (command[0] == "merge")
                {
                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        concat += list[i];
                    }

                    list.RemoveRange(startIndex, endIndex - startIndex + 1);
                    list.Insert(startIndex, concat);
                }

                else if (command[0] == "divide")
                {
                    List<string> listIndex = new List<string>();
                    int divide = int.Parse(command[2]);
                    string word = list[startIndex];
                    list.RemoveAt(startIndex);
                    int part = word.Length / divide;

                    for (int i = 0; i < divide; i++)
                    {
                        if (i == divide - 1)
                        {
                            listIndex.Add(word.Substring(i * part));
                        }
                        else
                        {
                            listIndex.Add(word.Substring(i * part,part));
                        }
                    }

                    list.InsertRange(startIndex,listIndex);

                }

                
                
            }

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }

        }
    }
}
