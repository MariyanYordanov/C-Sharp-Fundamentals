using System;

namespace _55.MultiplicationSign
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            double n3 = double.Parse(Console.ReadLine());
            
            double[] arr = new double[3] { n1, n2, n3 };
            
            MultiplicationSign(arr);
        }

        private static void MultiplicationSign(double[] arr)
        {
            int count = 0;

            if (arr[0] == 0 || arr[1] == 0 || arr[2] == 0)
            {
                Console.WriteLine("zero");
                return;
            }
            
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    count++;
                }

            }
            if (count % 2 == 0)
            {
                Console.WriteLine("positive");
            }
            else
            {
                Console.WriteLine("negative");
            }
        }

    }
}
