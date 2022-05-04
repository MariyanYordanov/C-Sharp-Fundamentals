using System;
using System.Linq;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] readenArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //int[] reorderArray = new int[readenArray.Length];

            //int n = int.Parse(Console.ReadLine());
            //if (n % readenArray.Length == 0)
            //{
            //    reorderArray = readenArray;
            //}
            //else if (n < readenArray.Length)
            //{
            //    for (int i = 0; i < readenArray.Length - n; i++)
            //    {
            //        reorderArray[i] = readenArray[i + n];
            //    }
            //    for (int i = readenArray.Length - n; 
            //        i < readenArray.Length; i++)
            //    {
            //        reorderArray[i] = readenArray[i - readenArray.Length + n];
            //    }
            //}
            //else if (n > readenArray.Length)
            //{
            //    int remainder = n % readenArray.Length;
            //    for (int i = 0; i < readenArray.Length - remainder; i++)
            //    {
            //        reorderArray[i] = readenArray[i + remainder];
            //    }
            //    for (int i = readenArray.Length - remainder; i < readenArray.Length; i++)
            //    {
            //        reorderArray[i] = readenArray[i - readenArray.Length + remainder];
            //    }
                
            //}
            //Console.WriteLine(string.Join(" ", reorderArray));

            //right decision


            var arr = Console.ReadLine().Split().ToArray();
            int n = int.Parse(Console.ReadLine());
            for (int j = 0; j < n; j++)
            {
                var end = arr[0];
                for (var i = 0; i < arr.Length - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }
                arr[arr.Length - 1] = end;
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
