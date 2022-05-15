using System;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int num = Math.Abs(number);
            Console.WriteLine(GetMultipleOfEvenAndOdds(num));
            
        }

        private static int GetSumOfOddDigits(int num)
        {
            int sumOddsDigit = 0;
            
            while (num != 0)
            {
                int temp = num % 10;
                if (temp % 2 != 0 )
                {
                    sumOddsDigit += temp;
                }
                num /= 10;
            }
            return sumOddsDigit;
        }

        private static int GetSumOfEvenDigits(int num)
        {
            int sumEvenDigit = 0;

            while (num != 0)
            {
                int temp = num % 10;
                if (temp % 2 == 0)
                {
                    sumEvenDigit += temp;
                }
                num /= 10;
            }
            return sumEvenDigit;
        }

        private static int GetMultipleOfEvenAndOdds(int num)
        {
            int multiply = GetSumOfEvenDigits(num) * GetSumOfOddDigits(num);
            return multiply;
        }
    }
}
