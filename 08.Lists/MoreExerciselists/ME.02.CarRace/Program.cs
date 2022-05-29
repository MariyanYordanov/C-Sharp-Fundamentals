using System;
using System.Linq;

namespace ME._02.CarRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            double sumPrev = 0;
            double sumCurrentLeft = 0;
            double sumCurrentRight = 0;
            for (int i = 0; i < arr.Length / 2; i++)
            {
                sumCurrentLeft += arr[i];
                sumPrev = sumCurrentLeft - arr[i];
                if (sumCurrentLeft == sumPrev)
                {
                    sumCurrentLeft *= 0.8;
                }

            }
            for (int i = arr.Length - 1; i > arr.Length / 2; i--)
            {
                sumCurrentRight += arr[i];
                sumPrev = sumCurrentRight - arr[i];
                if (sumCurrentRight == sumPrev)
                {
                    sumCurrentRight *= 0.8;
                }

            }
            string winner = " ";
            if (sumCurrentRight < sumCurrentLeft)
            {
                winner = "right";
            }
            else if (sumCurrentLeft < sumCurrentRight)
            {
                winner = "left";
            }
            double faster = Math.Min(sumCurrentLeft, sumCurrentRight);
            
            Console.WriteLine($"The winner is {winner} with total time: {faster}");
        }
    }
}
