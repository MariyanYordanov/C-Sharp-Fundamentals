using System;

namespace MudExamFundamentals_24_10_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOfAdventure = int.Parse(Console.ReadLine());
            int countOfPlayers = int.Parse(Console.ReadLine());
            double energyOfGroup = double.Parse(Console.ReadLine());
            double waterRepDayPerPerson = double.Parse(Console.ReadLine());
            double foodRepDayPerPerson = double.Parse(Console.ReadLine());
            double totalWater = daysOfAdventure * countOfPlayers * waterRepDayPerPerson;
            double totalFood = daysOfAdventure * countOfPlayers * foodRepDayPerPerson;
            for (int i = 1; i <= daysOfAdventure; i++)
            {
                double energyLoss = double.Parse(Console.ReadLine());
                energyOfGroup -= energyLoss;
                
                if (energyOfGroup <= 0)
                {
                    break;
                }
                if (i % 2 == 0)
                {
                    energyOfGroup *= 1.05;
                    totalWater -= totalWater * 0.3;
                    
                }
                if (i % 3 == 0)
                {
                    energyOfGroup *= 1.1;
                    totalFood -= totalFood / countOfPlayers;
                }
            }
            if (energyOfGroup > 0)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {energyOfGroup:f2} energy!");
            }
            else if (energyOfGroup <= 0)
            {
                Console.WriteLine($"You will run out of energy. You will be left with {totalFood:f2} food and {totalWater:f2} water.");
            }
        }
    }
}
