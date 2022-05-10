using System;
using System.Linq;

namespace _0004._Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] readenArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] manipulatedArray = new int[readenArray.Length / 2];

            for (int index = 0; index < (readenArray.Length / 4); index++)
            {
                manipulatedArray[(readenArray.Length / 4) - 1 - index] = readenArray[index] + readenArray[((readenArray.Length / 2) - 1) - index];
            }
            int i = 0;
            for (int ind = readenArray.Length / 4; ind < readenArray.Length / 2; ind++)
            {
                manipulatedArray[ind] = readenArray[(readenArray.Length / 2) + i] + readenArray[readenArray.Length - 1 -i];
                i++;
            }
            foreach (var item in manipulatedArray)
            {
                Console.Write(item + " ");
            }
        }
    }
}
