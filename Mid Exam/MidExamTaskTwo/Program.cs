using System;
using System.Linq;

namespace MidExamTaskTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int nuberOfPeopleInLine = int.Parse(Console.ReadLine());
            int[] wagonState = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int numberOfLeftPeopleInLine = nuberOfPeopleInLine;

            for (int i = 0; i < wagonState.Length; i++)
            {
                if (numberOfLeftPeopleInLine < 0)
                {
                    break;
                }
                int numberOfFreeSeats = 4 - wagonState[i];

                if (numberOfFreeSeats <= 4 && numberOfFreeSeats >= 0)
                {
                    numberOfLeftPeopleInLine -= numberOfFreeSeats;
                    if (numberOfLeftPeopleInLine < 0)
                    {
                        wagonState[i] = 4 + numberOfLeftPeopleInLine;
                        break;
                    }
                    else if (numberOfLeftPeopleInLine == 0)
                    {
                        wagonState[i] = 4;
                        break;
                    }
                    else
                    {
                        wagonState[i] = 4;
                    }
                    
                }
                else if (numberOfFreeSeats == 0)
                {
                    continue;
                }
                else if (numberOfLeftPeopleInLine < 0)
                {
                    break;
                }
            }

            if (numberOfLeftPeopleInLine < 0 && wagonState[wagonState.Length - 1] < 4)
            {
                Console.WriteLine("The lift has empty spots!");
                foreach (var item in wagonState)
                {
                    Console.Write(item + " ");
                }
            }
            else if (numberOfLeftPeopleInLine > 0)
            {
                Console.WriteLine($"There isn't enough space! {numberOfLeftPeopleInLine} people in a queue!");
                foreach (var item in wagonState)
                {
                    Console.Write(item + " ");
                }
            }
            else if (numberOfLeftPeopleInLine == 0)
            {
                foreach (var item in wagonState)
                {
                    Console.Write(item + " ");
                }
            }
        }
    }
}
