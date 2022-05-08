using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string peopleType = Console.ReadLine();
            string day = Console.ReadLine();

            double price = 0;


            if (peopleType == "Students")
            {
                if (day == "Friday")
                {
                    price = 8.45;
                }

                else if (day == "Saturday")
                {
                    price = 9.80;
                }

                else if (day == "Sunday")
                {
                    price = 10.46;
                }
            }

            else if (peopleType == "Business")
            {
                if (day == "Friday")
                {
                    price = 10.90;
                }

                else if (day == "Saturday")
                {
                    price = 15.60;
                }

                else if (day == "Sunday")
                {
                    price = 16;
                }
            }

            else if (peopleType == "Regular")
            {
                if (day == "Friday")
                {
                    price = 15;
                }

                else if (day == "Saturday")
                {
                    price = 20;
                }

                else if (day == "Sunday")
                {
                    price = 22.50;
                }
            }

            if (peopleCount >= 100 && peopleType == "Business")
            {
                peopleCount -= 10;
            }

            double totalPrice = price * peopleCount;

            if (peopleCount >= 30 && peopleType == "Students")
            {
                totalPrice -= totalPrice * 0.15;
            }

            if ((peopleCount >= 10 && peopleCount <= 20) && peopleType == "Regular")
            {
                totalPrice -= totalPrice * 0.05;
            }

            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
