using System;

namespace _04._RefactoringPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int index = 2; index <= number; index++)
            {
                
                string prime = "true";
                for (int divider = 2; divider < index; divider++)
                {
                     bool isPrime = true;
                    if (index % divider == 0)
                    {
                        isPrime = false;
                        prime = "false";
                        break;
                    }
                    else
                    {
                        prime = "true";
                    }
                }
                Console.WriteLine("{0} -> {1}", index, prime);
            }

        }
    }
}
