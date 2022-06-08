using System;

namespace _010.TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            TopNumberInRange(num);
            
        }

        private static void TopNumberInRange(int num)
        {
           for (int i = 1; i <= num; i++)
           {

               if (OddDigitCheck(i) && IsSumOfDigitIsDividedByEight(i))
               {
                   Console.WriteLine(i);
               }
           }
        }

        private static bool IsSumOfDigitIsDividedByEight(int num)
        {
            int sum = 0;
            int temp = num;
            while (num > 0)
            {
                temp = num % 10;
                sum += temp;
                num /= 10;
            }
            return sum % 8 == 0;
        }

        private static bool OddDigitCheck(int num)
        {
            bool isOdd = false;
            int temp = num;
            while (num > 0)
            {
                temp = num % 10;
                if (temp % 2 != 0)
                {
                    isOdd = true;
                    break;
                }
                num /= 10;
            }
            return isOdd;
        }

    }
}
