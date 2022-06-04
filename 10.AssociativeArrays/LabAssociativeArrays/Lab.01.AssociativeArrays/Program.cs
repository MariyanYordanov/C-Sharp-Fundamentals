using System;
using System.Collections.Generic;
using System.Linq;

namespace AssociativeArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            //Dictionary<double, int> counts = new Dictionary<double, int>();
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (!counts.ContainsKey(numbers[i]))
            //    {
            //        counts.Add(numbers[i], 0);
            //    }

            //    counts[numbers[i]]++;
            //}
            //foreach (var item in counts)
            //{
            //    Console.WriteLine($"{item.Key} -> {item.Value}");
            //}

            //HOW TO REVERSE STRING

            //  1.
            //string s = "some text";
            //s = new string(s.ToCharArray().Reverse().ToArray());
            //Console.WriteLine(s);

            //  2.
            //char[] charArray = s.ToCharArray();
            //Array.Reverse(charArray);
            //s = new string(charArray);
            //Console.WriteLine(s.ToString());


            
            int[] first = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] second = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if (first.Length == 1 && second.Length == 1)
            {

            }
            for (int i = 0; i < first.Length; i++)
            {
                for (int j = 0; j < second.Length; j++)
                {
                    if (first[i] == second[j])
                    {
                        int[] temp = new int[first.Length - 1];
                        int count = 0;
                        for (int k = 0; k <= temp.Length; k++)
                        {
                            if (first[i] != first[k])
                            {
                                temp[count] = first[k];
                                count++;
                            }
                            
                        }

                        first = temp;
                        i--;
                    }

                }

            }

            int[] c = new int[first.Length];
            c = first;
            Console.WriteLine(string.Join(" ",c));
        }
    }
}
