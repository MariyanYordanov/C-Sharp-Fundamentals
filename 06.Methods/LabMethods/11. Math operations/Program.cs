using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            double num2 = double.Parse(Console.ReadLine());
            
            
            switch (@operator)
            {
                case "+":
                    Console.WriteLine(Sum(num1, num2));
                    break;
                case "-":
                    Console.WriteLine(Difference(num1, num2));
                    break;
                case "*":
                    Console.WriteLine(Multiplication(num1, num2));
                    break;
                case "/":
                    Console.WriteLine(Division(num1, num2));
                    break;
            }
        }

        private static double Division(double num1, double num2)
        {
            double result = num1 / num2;
            return result;
        }

        private static double Multiplication(double num1, double num2)
        {
            double result = num1 * num2;
            return result;
        }

        private static double Difference(double num1, double num2)
        {
            double result = num1 - num2;
            return result;
        }

        private static double Sum(double num1, double num2)
        {
            double result = num1 + num2;
            return result;
        }
    }
}
