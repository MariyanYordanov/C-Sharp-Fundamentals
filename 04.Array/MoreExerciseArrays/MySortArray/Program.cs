using System;
using System.Linq;


namespace _01._Encrypt__Sort_and_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] ordered = Console.ReadLine().Split().Select(int.Parse).ToArray(); ; 
			
            for (int i = 0; i < ordered.Length - 1; i++)
            {
                int minValue = ordered[i];
                for (int j = i + 1; j < ordered.Length; j++)
                {
                    int temp = ordered[j];
                    if (temp < minValue)
                    {
                        ordered[i] = temp;
                        ordered[j] = minValue;
                    }
                    minValue = ordered[i];
                }
            }
            foreach (var item in ordered)
            {
                Console.WriteLine(item);
            }
        }
    }
}
