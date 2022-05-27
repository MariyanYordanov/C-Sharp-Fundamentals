using System;
using System.Linq;
using System.Collections.Generic;

namespace Lab._06.ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] comand = Console.ReadLine().Split();

            while (comand[0] != "end")
            {
                
                

                if (comand[0] == "Add")
                {
                    int number1 = int.Parse(comand[1].ToString());
                    AddNumber(number1, list);
                }
                if (comand[0] == "Remove")
                {
                    int number1 = int.Parse(comand[1].ToString());
                    RemoveNumber(number1, list);
                }
                if (comand[0] == "RemoveAt")
                {
                    int number1 = int.Parse(comand[1].ToString());
                    RemoveIndex(number1, list);
                }
                if (comand[0] == "Insert")
                {
                    int number1 = int.Parse(comand[1].ToString());
                    int number2 = int.Parse(comand[2].ToString());
                    InsertNumberWhitIndex(number1,number2,list);
                }

                comand = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(" ",list));
        }

        private static List<int> InsertNumberWhitIndex(int number1, int number2, List<int> list)
        {
            list.Insert(number2,number1);
            return list;
        }

        private static List<int> RemoveIndex(int number2, List<int> list)
        {
            list.RemoveAt(number2);
            return list;
        }

        private static List<int> RemoveNumber(int number1, List<int> list)
        {
            list.Remove(number1);
            return list;
        }

        private static List<int> AddNumber(int number1, List<int> list)
        {
            list.Add(number1);
            return list;

        }
    }
}
