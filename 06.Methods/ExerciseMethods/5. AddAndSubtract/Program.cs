using System;

namespace _005._AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(AddAndSutract(firstNumber, secondNumber, thirdNumber));
            
        }

        private static int AddAndSutract(int firstNumber, int secondNumber, int thirdNumber)
        {
            return (firstNumber + secondNumber) - thirdNumber;
        }
    }
}
