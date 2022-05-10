using System;

namespace _03._Recursive_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //Console.WriteLine(GetFibonacci(n));
            Console.WriteLine(GetFibonacciRecursive(n)); ;
           
        }

        //private static int GetFibonacci(int n)
        //{
        //    int[] fibonachiSequences = new int[n];
        //    fibonachiSequences[0] = 1;
        //    fibonachiSequences[1] = 1;
        //    for (int i = 2; i < n; i++)
        //    {
        //        fibonachiSequences[i] = fibonachiSequences[i - 1] + fibonachiSequences[i- 2];
        //    }
        //    return fibonachiSequences[n - 1];
        //}


        private static int GetFibonacciRecursive(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else if (n <= 2)
            {
                return 1;
            }
            else
            {
                return GetFibonacciRecursive(n - 1) + GetFibonacciRecursive(n - 2);
            }
        }

    }

}
