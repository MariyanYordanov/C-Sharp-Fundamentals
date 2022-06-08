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
            bool isListIsSame = false;
            while (comand[0] != "end")
            {
                if (comand[0] == "Contains")
                {
                    int num1 = int.Parse(comand[1].ToString());
                    ContainsNumber(num1, list);
                }
                if (comand[0] == "PrintEven")
                {
                    PrintEven(list);
                    Console.WriteLine();
                }
                if (comand[0] == "PrintOdd")
                {
                    PrintOdd(list);
                    Console.WriteLine();
                }
                if (comand[0] == "GetSum")
                {
                    GetSum(list);
                }
                if (comand[0] == "Filter")
                {
                    int number2 = int.Parse(comand[2].ToString());
                    Filter(comand[1],number2,list);
                    Console.WriteLine();
                }

                if (comand[0] == "Add")
                {
                    int number1 = int.Parse(comand[1].ToString());
                    AddNumber(number1, list);
                    isListIsSame = true;
                }
                if (comand[0] == "Remove")
                {
                    int number1 = int.Parse(comand[1].ToString());
                    RemoveNumber(number1, list);
                    isListIsSame = true;
                }
                if (comand[0] == "RemoveAt")
                {
                    int number1 = int.Parse(comand[1].ToString());
                    RemoveIndex(number1, list);
                    isListIsSame = true;
                }
                if (comand[0] == "Insert")
                {
                    int number1 = int.Parse(comand[1].ToString());
                    int number2 = int.Parse(comand[2].ToString());
                    InsertNumberWhitIndex(number1, number2, list);
                    isListIsSame = true;
                }
                comand = Console.ReadLine().Split();

                if (comand[0] == "end" && isListIsSame == true)
                {
                    Console.WriteLine(string.Join(" ",list));
                }
            }
            
        }

        private static void Filter(string comand, int number, List<int> list)
        {
            if (comand == "<")
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (list[j] < number)
                    {
                        Console.Write(list[j] + " ");
                    }
                    
                }
            }
            if (comand == ">")
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (list[j] > number)
                    {
                        Console.Write(list[j] + " ");
                    }
                }
            }
            if (comand == ">=")
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (list[j] >= number)
                    {
                        Console.Write(list[j] + " ");
                    }
                }
            }
            if (comand == "<=")
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (list[j] <= number)
                    {
                        Console.Write(list[j] + " ");
                    }
                }
            }
        }

        private static void GetSum(List<int> list)
        {
            int sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }
            Console.WriteLine(sum);
        }

        private static void PrintOdd(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 != 0)
                {
                    Console.Write(list[i] + " ");
                }
            }
        }

        private static void PrintEven(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 0)
                {
                    Console.Write(list[i] + " ");
                }
            }
            
        }

        private static void ContainsNumber(int number1, List<int> list)
        {
           if (list.Contains(number1))
           {
                Console.WriteLine("Yes");
           }
           else
           {
               Console.WriteLine("No such number");    
           }
        }

        private static List<int> InsertNumberWhitIndex(int number1, int number2, List<int> list)
        {
            list.Insert(number2, number1);
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
