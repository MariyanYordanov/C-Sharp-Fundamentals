using System;

namespace _07._Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfDay = Console.ReadLine().ToLower();
            int personAge = int.Parse(Console.ReadLine());
            double price = 0;

            if (typeOfDay == "weekday")
            {
                if ((personAge >= 0 && personAge <= 18) || (personAge > 64 && personAge <= 122))
                {
                    price += 12;
                }

                else if (personAge > 18 && personAge <= 64)
                {
                    price += 18;
                }
            }

            else if (typeOfDay == "weekend")
            {
                if ((personAge >= 0 && personAge <= 18) || (personAge > 64 & personAge <= 122))
                {
                    price += 15;
                }

                else if (personAge > 18 && personAge <= 64)
                {
                    price += 20;
                }
            }

            else if (typeOfDay == "holiday")
            {
                if (personAge >= 0 && personAge <= 18)
                {
                    price += 5;
                }

                else if (personAge > 18 && personAge <= 64)
                {
                    price += 12;
                }

                else if (personAge > 64 && personAge <= 122)
                {
                    price += 10;
                }
            }

            if (price != 0)
            {
                Console.WriteLine($"{price}$");
            }

            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
