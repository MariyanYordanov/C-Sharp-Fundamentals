using System;
using System.Linq;

namespace _09._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string sequences = Console.ReadLine();

            int[] printArray = new int[n];
            
            int sumMax = 0;
            int lenghtMax = 1;
            int lefterStart = n;
            int sample = 0;
            int bestSample = 0;
            bool isBigger = false;
            while (sequences != "Clone them!")
            {
                sample++;
                int sum = 0;
                int j = 0;
                int[] reorderArray = new int[n];
                for (int i = 0; i < sequences.Length; i++)
                {
                    char exclamationMark = char.Parse(sequences[i].ToString());
                    if (exclamationMark != 33)
                    {
                        reorderArray[j] = exclamationMark - 48;
                        sum += reorderArray[j];
                        j++;
                    }
                }
                if (sum >= sumMax)
                {
                    sumMax = sum;
                }
                for (int k = 0; k < reorderArray.Length - 1; k++)
                {
                    if (reorderArray[k] == reorderArray[k + 1])
                    {
                        int lenght = 1;
                        int start = k;
                        if (start < lefterStart)
                        {
                            lefterStart = start;
                            isBigger = true;
                            bestSample = sample;
                            printArray = reorderArray;
                        }
                        lenght++;
                        if (lenght > lenghtMax)
                        {
                            lenghtMax = lenght;
                            isBigger = true;
                            bestSample = sample;
                            printArray = reorderArray;
                        }
                        else if (lenght == lenghtMax)
                        {
                            if (lefterStart > start)
                            {
                                isBigger = true;
                                bestSample = sample;
                                printArray = reorderArray;
                            }
                            else if (lefterStart == start)
                            {
                                if (sum >= sumMax)
                                {
                                    isBigger = true;
                                    bestSample = sample;
                                    printArray = reorderArray;
                                }
                            }
                        }
                    }
                }
                sequences = Console.ReadLine();
            }
            if (isBigger)
            {
                int suma = 0;
                for (int i = 0; i < printArray.Length; i++)
                {
                    suma += printArray[i];
                }
                Console.WriteLine($"Best DNA sample {bestSample} with sum: {suma}.");
                foreach (var item in printArray)
                {
                    Console.Write(item + " ");
                }
            }
        }
    }
}
