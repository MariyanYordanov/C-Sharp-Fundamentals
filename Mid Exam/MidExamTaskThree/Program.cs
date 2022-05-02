using System;
using System.Collections.Generic;
using System.Linq;

namespace MidExamTaskThree
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sequence = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string input = Console.ReadLine();
            
            int moves = 0;

            while (true)
            {
                string[] index = input.Split();
                if (index[0] == "end")
                {
                    break;
                }
                int index1 = int.Parse(index[0]);
                int index2 = int.Parse(index[1]);
                int indexOne = Math.Min(index1, index2);
                int indexTwo = Math.Max(index1, index2);
                moves++;
                
                if (indexOne == indexTwo || indexOne > sequence.Count || indexOne < 0 || indexTwo > sequence.Count || indexTwo < 0)
                {
                    sequence.Insert((sequence.Count / 2), $"-{moves}a");
                    sequence.Insert((sequence.Count / 2), $"-{moves}a");
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    
                }
                else
                {
                    if (sequence[indexOne] == sequence[indexTwo])
                    {
                        Console.WriteLine($"Congrats! You have found matching elements - {sequence[indexOne]}!");
                        sequence.RemoveAt(indexOne);
                        sequence.RemoveAt(indexTwo - 1);
                        if (sequence.Count == 0)
                        {
                            Console.WriteLine($"You have won in {moves} turns!");
                            return;
                        }

                    }
                    else if (sequence[indexOne] != sequence[indexTwo])
                    {
                        Console.WriteLine("Try again!");
                    }

                }
                input = Console.ReadLine();
            }

            if (sequence.Count > 0)
            {
                Console.WriteLine($"Sorry you lose :(");
                Console.WriteLine(string.Join(" ",sequence));
            }
        }
    }
}
