using System;
using System.Linq;

namespace _05._Longest_Increasing_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 3, 14, 5, 12, 15, 7, 8, 9, 11, 10, 1 };
            
            int counter = 1;
            int[] temp = new int[counter];
            for (int i = 0; i < nums.Length - 2; i++)
            {
                temp[i] = nums[i];
                for (int j = i + 1; j < nums.Length - 1; j++)
                {
                    int[] prev = new int[counter];
                    if (nums[j] < nums[j + 1])
                    {
                        counter++;
                        prev = new int[counter];
                        for (int k = 0; k < temp.Length; k++)
                        {
                            prev[k] = temp[k];
                            if (nums[j - 1] < nums[j + 1])
                            {
                                prev[k + 1] = nums[j + 1];
                            }
                            else
                            {
                                prev[k] = nums[j];
                                prev[k + 1] = nums[j + 1];
                            }
                        }
                        temp = prev;
                    }
                    else
                    {
                        counter++;
                        prev = new int[counter];
                        for (int k = 0; k < temp.Length; k++)
                        {
                            prev[k] = temp[k];
                            if (nums[j - 1] < nums[j + 1])// if [2] < [4] && [3] < [4]
                            {
                                prev[k + 1] = nums[j + 1];
                            }
                            else
                            {
                                prev[k] = nums[j];
                                prev[k + 1] = nums[j + 1]; 
                            }

                        }
                        temp = prev;
                    }
                }
                
            }
        }
    }
}
