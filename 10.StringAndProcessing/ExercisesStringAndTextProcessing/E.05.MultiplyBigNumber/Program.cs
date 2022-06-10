using System;
using System.Text;

namespace E._05.MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            int reminder = 0;
            StringBuilder stringNumber = new StringBuilder();
            if (n == 0 || input =="0")
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = input.Length - 1; i >= 0; i--)
            {
                int number = int.Parse(input[i].ToString());
                int product = n * number + reminder;
                int result = product % 10;
                reminder = product / 10;
                stringNumber.Insert(0, result);
            }

            if (reminder > 0)
            {
                stringNumber.Insert(0, reminder);
            }
            
            Console.WriteLine(stringNumber);
        }

    }
}
