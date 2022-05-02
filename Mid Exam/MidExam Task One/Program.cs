using System;

namespace MidExam1Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            decimal priceSum = 0;
            decimal totalPrice = 0;

            while (input == input)
            {
                if (input == "special" || input == "regular")
                {
                    break;
                }
                decimal partPrice = decimal.Parse(input);

                if (partPrice <= 0)
                {
                    Console.WriteLine("Invalid price!");
                }
                else
                {
                    priceSum += partPrice;
                }
                
                input = Console.ReadLine();

                
            }

            decimal taxes = priceSum * (decimal)0.2;

            if (input == "special")
            {
                totalPrice = priceSum + taxes - ((priceSum + taxes) * (decimal)0.1);
            }
            else if (input == "regular")
            {
                totalPrice = priceSum + taxes;
            }
            if (totalPrice == 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else
            {
                Console.WriteLine($"Congratulations you've just bought a new computer!\nPrice without taxes: {priceSum:f2}$\nTaxes: {taxes:f2}$\n-----------\nTotal price: {totalPrice:f2}$");
            }
        }  
    }
}
