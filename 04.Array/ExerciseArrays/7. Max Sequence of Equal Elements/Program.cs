using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] readenArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bigger = 0;
            int index = 0;
            for (int i = 0; i < readenArray.Length - 1; i++)
            {
                int count = 0;
                if (readenArray[i] == readenArray[i + 1])
                {
                    count++;
                    for (int j = i; j < readenArray.Length - 1; j++)
                    {
                        if (readenArray[j] == readenArray[j + 1])
                        {
                            count++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                if (count > bigger)
                {
                    bigger = count;
                    index = readenArray[i];
                }
            }
            for (int j = 0; j < bigger; j++)
            {
                Console.Write(index + " ");
            }
        }   
    }
}
