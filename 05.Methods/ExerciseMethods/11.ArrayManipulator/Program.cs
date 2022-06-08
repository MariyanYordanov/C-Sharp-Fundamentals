using System;
using System.Linq;

namespace _011.ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] readenArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[] input = Console.ReadLine().Split();

            while (input[0] != "end")
            {
                if (input[0] == "exchange")
                {
                    readenArray = ExchanceSubArray(readenArray, int.Parse(input[1]));
                }
                else if (input[0] == "max" || input[0] == "min")
                {
                    FindMinOrMax(readenArray, input[0], input[1]);
                }
                else if (input[0] == "first" || input[0] == "last")
                {
                    FindNumbers(readenArray, input[0], int.Parse(input[1]), input[2]);
                }

                input = Console.ReadLine().Split();
            }
            Console.WriteLine($"[{string.Join(", ", readenArray)}]");
        }

        static void FindNumbers(int[] readenArray, string v1, int v2, string v3)
        {
            if (v2 > readenArray.Length || v2 < 0)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            int[] print = new int[v2];
            int[] printreverse = new int[v2];

            if (v1 == "first")
            {
                int countPrintIndex = - 1;
                for (int i = 0; i < readenArray.Length; i++)
                {
                    if (v3 == "odd")
                    {
                        if (readenArray[i] % 2 != 0)
                        {
                            countPrintIndex++;
                            print[countPrintIndex] = readenArray[i];
                            v2--;
                        }
                    }
                    else if (v3 == "even")
                    {
                        if (readenArray[i] % 2 == 0)
                        {
                            countPrintIndex++;
                            print[countPrintIndex] = readenArray[i];
                            v2--;
                        }
                    }
                    if (v2 == 0)
                    {
                        break;
                    }
                }
                if (countPrintIndex == -1)
                {
                    Console.WriteLine("[]");
                }
                else
                {
                    if (countPrintIndex < v2)
                    {
                        int[] orderedPrint = new int[print.Length - v2];
                        for (int i = 0; i < orderedPrint.Length; i++)
                        {
                            orderedPrint[i] = print[i];
                        }

                        Console.WriteLine($"[{string.Join(", ", orderedPrint)}]");
                    }
                    else
                    {
                        Console.WriteLine($"[{string.Join(", ", print)}]");
                    }
                }
            }
            else if (v1 == "last")
            {
                int countPrintIndex = -1;
                for (int i = readenArray.Length - 1; i >= 0; i--)
                {
                    if (v3 == "odd")
                    {
                        if (readenArray[i] % 2 != 0)
                        {
                            countPrintIndex++;
                            printreverse[countPrintIndex] = readenArray[i];
                            v2--;
                        }
                    }
                    if (v3 == "even")
                    {
                        if (readenArray[i] % 2 == 0)
                        {
                            countPrintIndex++;
                            printreverse[countPrintIndex] = readenArray[i];
                            v2--;
                        }
                    }
                    if (v2 == 0)
                    {
                        break;
                    }
                }

                if (countPrintIndex == -1)
                {
                    Console.WriteLine("[]");
                }
                else
                {
                    if (countPrintIndex < v2)
                    {
                        int[] orderedPrint = new int[printreverse.Length - v2];
                        for (int i = 0; i < orderedPrint.Length; i++)
                        {
                            orderedPrint[i] = printreverse[i];
                        }

                        Console.WriteLine($"[{string.Join(", ", orderedPrint)}]");
                    }
                    else
                    {
                        Console.WriteLine($"[{string.Join(", ", printreverse)}]");
                    }
                }
            }

        }

        static void FindMinOrMax(int[] readenArray, string v1, string v2)
        {
            int minOdd = int.MaxValue;
            int countMinOdd = -1;
            int maxOdd = int.MinValue;
            int countMaxOdd = -1;
            int minEven = int.MaxValue;
            int countMinEven = -1;
            int maxEven = int.MinValue;
            int countMaxEven = -1;
            for (int i = 0; i < readenArray.Length; i++)
            {
                if (readenArray[i] % 2 != 0)
                {
                    if (readenArray[i] < minOdd)
                    {
                        countMinOdd = i;
                        minOdd = readenArray[i];
                    }
                    if (readenArray[i] > maxOdd)
                    {
                        countMaxOdd = i;
                        maxOdd = readenArray[i];
                    }
                }
                if (readenArray[i] % 2 == 0)
                {
                    if (readenArray[i] > maxEven)
                    {
                        countMaxEven = i;
                        maxEven = readenArray[i];
                    }
                    if (readenArray[i] < minEven)
                    {
                        countMinEven = i;
                        minEven = readenArray[i];
                    }
                }
            }
            if (v1 == "min")
            {
                if (v2 == "odd")
                {
                    if (minOdd == int.MaxValue)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(countMinOdd);
                    }
                }
                else if (v2 == "even")
                {
                    if (minEven == int.MaxValue)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(countMinEven);
                    }
                }
            }
            else if (v1 == "max")
            {
                if (v2 == "odd")
                {
                    if (maxOdd == int.MinValue)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(countMaxOdd);
                    }
                }
                else if (v2 == "even")
                {
                    if (maxEven == int.MinValue)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(countMaxEven);
                    }
                }
            }
        }

        static int[] ExchanceSubArray(int[] readenArray, int input)
        {
            if (input > readenArray.Length || input < 0)
            {
                Console.WriteLine("Invalid index");
                return readenArray;
            }

            for (int i = 0; i < input + 1; i++)
            {
                int temp = readenArray[0];
                for (int j = 0; j < readenArray.Length - 1; j++)
                {
                    readenArray[j] = readenArray[j + 1];
                }
                readenArray[readenArray.Length - 1] = temp;
            }
            return readenArray;
        }
    }
}
