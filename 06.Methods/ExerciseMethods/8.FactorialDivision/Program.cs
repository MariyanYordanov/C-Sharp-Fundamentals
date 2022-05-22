using System;

namespace _08.FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            Console.WriteLine($"{FactorialDivision(firstNumber, secondNumber):f2}");
        }

        private static double FactorialDivision(double firstNumber, double secondNumber)
        {
            return FactorialFromNumber(firstNumber) / FactorialFromNumber(secondNumber);
        }

        private static double FactorialFromNumber(double number)
        {
            double result = 1;
            for (int i = 1; i < number ; i++)
            {
                result *= (i + 1);
            }
            return result;
        }
    }
}
