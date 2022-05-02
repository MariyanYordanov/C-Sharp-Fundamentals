using System;
using System.Collections.Generic;
using System.Linq;

namespace E._4._1._3.NeedForSpeedIII
{
    class Program
    {
        class Cars
        {
            public int Mileage { get; set; }
            public int Fuel { get; set; }

        }
        static void Main(string[] args)
        {
            Dictionary<string, Cars> data = new Dictionary<string, Cars>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] cars = Console.ReadLine().Split("|");
                string name = cars[0];
                int mileage = int.Parse(cars[1]);
                int fuel = int.Parse(cars[2]);
                Cars car = new Cars()
                {
                    Mileage = mileage,
                    Fuel = fuel
                };

                data.Add(name, car);
            }

            string input = Console.ReadLine();
            while (input != "Stop")
            {
                string[] cmd = input.Split(" : ");
                string leedCommand = cmd[0];
                if (leedCommand == "Drive")
                {
                    string car = cmd[1];
                    int distance = int.Parse(cmd[2]);
                    int fuel = int.Parse(cmd[3]);
                    if (data.ContainsKey(car))
                    {
                        if (data[car].Fuel < fuel)
                        {
                            Console.WriteLine("Not enough fuel to make that ride");
                        }
                        else if (data[car].Fuel >= fuel)
                        {
                            data[car].Fuel -= fuel;
                            data[car].Mileage += distance;
                            Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                        }

                        if (data[car].Mileage >= 100000)
                        {
                            Console.WriteLine($"Time to sell the {car}!");
                            data.Remove(car);
                        }

                    }

                }
                else if (leedCommand == "Refuel")
                {
                    string car = cmd[1];
                    int fuel = int.Parse(cmd[2]);
                    if (data.ContainsKey(car))
                    {
                        int prevFuel = data[car].Fuel;
                        data[car].Fuel += fuel;
                        if (data[car].Fuel > 75)
                        {
                            data[car].Fuel = 75;
                        }

                        Console.WriteLine($"{car} refueled with {data[car].Fuel - prevFuel} liters");
                    }
                    
                }
                else if (leedCommand == "Revert")
                {
                    string car = cmd[1];
                    int kilometers = int.Parse(cmd[2]);
                    if (data.ContainsKey(car))
                    {
                        int amountReverted = data[car].Mileage - kilometers;
                        data[car].Mileage -= kilometers;
                        if (data[car].Mileage < 10000)
                        {
                            data[car].Mileage = 10000;
                        }
                        else
                        {
                            Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");
                        }

                    }

                }

                input = Console.ReadLine();
            }

            foreach (var item in data.OrderByDescending(x => x.Value.Mileage))
            {
                Console.WriteLine($"{item.Key} -> Mileage: {item.Value.Mileage} kms, Fuel in the tank: {item.Value.Fuel} lt.");
            }
        }
    }
}
