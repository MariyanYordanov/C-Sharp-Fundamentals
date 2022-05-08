using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyIvan = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());
            int freeBelt = 0;

            if (studentsCount >= 6)
            {
                for (int i = 6; i <= studentsCount; i++)
                {
                    if (i % 6 == 0)
                    {
                        freeBelt += 1;
                    }
                }
            }
            
            double lightsaberTotalPrice = Math.Ceiling(studentsCount * 1.10) * lightsaberPrice;

            double robeTotalPrice = robePrice * studentsCount;

            double beltTotalPrice = beltPrice * (studentsCount - freeBelt);

            double totalPricee = lightsaberTotalPrice + robeTotalPrice + beltTotalPrice;

            if (totalPricee <= moneyIvan)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPricee:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {Math.Abs(totalPricee - moneyIvan):f2}lv more.");
            }
        }
    }
}
