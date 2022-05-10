using System;
using System.Linq;

namespace MoreArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] readenArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int count = 1;
            int countMax = 1;
            int startIndex = 0;
            int start = 0;
            int endIndex = 0;
            int end = 0;
            for (int i = 0; i < readenArray.Length - 1; i++)
            {
                if (readenArray[i + 1] > readenArray[i])
                {
                    count++;
                    
                    if (start == 0)
                    {
                        start = i;
                        if (start > startIndex)
                        {
                            startIndex = start;
                        }
                    }
                    if (count > countMax)
                    {
                        countMax = count;
                        end = i + 1;
                        if (end > endIndex)
                        {
                            endIndex = end;
                        }
                    }
                }
                else
                {
                    count = 1;
                    start = 0;
                    end = 0;
                }
            }
            
            for (int i = startIndex; i <= endIndex; i++)
            {
                Console.Write(readenArray[i] + " ");
            }

        }
    }
}
