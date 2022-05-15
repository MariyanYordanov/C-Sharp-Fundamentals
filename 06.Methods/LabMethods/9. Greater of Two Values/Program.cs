using System;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            if (input == "int")
            {
                GetMaxIteger(first, second);
            }
            else if (input == "char")
            {
                GetMaxCharacter(first, second);
            }
            else if (input == "string")
            {
                GetMaxString(first, second);
            }
        }

        private static void GetMaxString(string first, string second)
        {
            int[] one = new int[first.Length];
            int[] two = new int[second.Length];
            bool isBiggerFirst = false;
            bool isBiggerSecond = false;
            for (int i = 0; i < first.Length; i++)
            {
                one[i] = first[i];
                if (one[i] >= 65 && one[i] <= 90)
                {
                    one[i] += 100;
                }

            }

            for (int i = 0; i < second.Length; i++)
            {
                two[i] = second[i];
                if (two[i] >= 65 && two[i] <= 90)
                {
                    two[i] += 100;
                }

            }
            for (int i = 0; i < one.Length; i++)
            {
                if (one[i] == two[i])
                {
                    isBiggerFirst = true;
                    continue;
                }
                else if (one[i] > two[i])
                {
                    isBiggerFirst = true;
                    break;
                }
                else if (one[i] < two[i])
                {
                    isBiggerSecond = true;
                    break;
                }

            }

            if (isBiggerFirst)
            {
                Console.WriteLine(first);
            }
            else if (isBiggerSecond) 
            {
                Console.WriteLine(second);
            }
            else
            {
                Console.WriteLine(first);
            }

        }
       
        private static void GetMaxCharacter(string first, string second)
        {
            char one = char.Parse(first);
            char two = char.Parse(second);
            if (one > two)
            {
                Console.WriteLine(one);
            }
            else if (one < two)
            {
                Console.WriteLine(two);
            }
            else if (one == two)
            {
                Console.WriteLine(one);
            }
        }

        private static void GetMaxIteger(string first, string second)
        {
            int one = int.Parse(first);
            int two = int.Parse(second);
            if (one > two)
            {
                Console.WriteLine(one);
            }
            else if (one < two)
            {
                Console.WriteLine(two);
            }
            else if (one == two)
            {
                Console.WriteLine(one);
            }
        }
    }
}
