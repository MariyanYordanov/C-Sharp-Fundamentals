using System;

namespace _12._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= number; i++)
            {
                int sum = 0;
                int temporary = i;
                bool specialNumber;
                while (i > 0)
                {
                    sum += i % 10;
                    i /= 10;
                }
                specialNumber = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", temporary, specialNumber);
                i = temporary;
            }
        }
    }
}
