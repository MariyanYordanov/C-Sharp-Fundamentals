using System;

namespace _4.TribonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                Console.Write(1 + " ");
            }
            else if (n == 2)
            {
                Console.Write(1 + " ");
                Console.Write(1 + " ");
            }
            else if (n == 3)
            {
                Console.Write(1 + " ");
                Console.Write(1 + " ");
                Console.Write(2 + " ");
            }
            else
            {
                TribonachiSequences(n);
            }
            
        }

        private static void TribonachiSequences(int n)
        {
            int[] fibonachiSequences = new int[n];

            fibonachiSequences[0] = 1;
            fibonachiSequences[1] = 1;
            fibonachiSequences[2] = 2;
            
            Console.Write(fibonachiSequences[0] + " ");
            Console.Write(fibonachiSequences[1] + " ");
            Console.Write(fibonachiSequences[2] + " ");

            for (int i = 3; i < fibonachiSequences.Length; i++)
            {
                fibonachiSequences[i] = fibonachiSequences[i - 1] + fibonachiSequences[i - 2] + fibonachiSequences[i - 3];
                Console.Write(fibonachiSequences[i] + " ");
            }
        }
    }
}
