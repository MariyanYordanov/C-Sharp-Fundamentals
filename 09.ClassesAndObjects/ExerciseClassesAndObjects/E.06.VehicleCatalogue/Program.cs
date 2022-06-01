using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E._06.VehicleCatalogue
{
    class Program
    {
        internal enum VehicleCatalogue
        {
            Car,
            Truck
        }
        internal class Vehicles
        {
            public Vehicles(VehicleCatalogue type, string model, string color, int horsepower)
            {
                Type = type;
                Model = model;
                Color = color;
                Horsepower = horsepower;
            }

            public VehicleCatalogue Type { get; }
            public string Model { get; }
            public string Color { get; }
            public int Horsepower { get; }

            public override string ToString()
            {
                var builder = new StringBuilder();
                builder.AppendLine($"Type: {Type}");
                builder.AppendLine($"Model: {Model}");
                builder.AppendLine($"Color: {Color}");
                builder.AppendLine($"Horsepower: {Horsepower}");
                return builder.ToString().TrimEnd();

            }
        }

        static void Main(string[] args)
        {
            List<Vehicles> vehicle = new List<Vehicles>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                string[] cmd = input.Split();
                VehicleCatalogue vehicleType;
                bool isVehicleTypeParsable = Enum.TryParse(cmd[0],true,out vehicleType);
                if (isVehicleTypeParsable)
                {
                    string currentModel = cmd[1];
                    string currentColor = cmd[2];
                    int currentHorsepower = int.Parse(cmd[3]);
                    Vehicles newVehicle = new Vehicles(vehicleType, currentModel, currentColor, currentHorsepower);
                    vehicle.Add(newVehicle);
                }
               
            }

            while (true)
            {
                string info = Console.ReadLine();
                if (info == "Close the Catalogue")
                {
                    break;
                }

                Vehicles deseriedVehicle = vehicle.FirstOrDefault(vehicle => vehicle.Model == info);
                Console.WriteLine(deseriedVehicle);
            }
            var cars = vehicle.Where(car => car.Type == VehicleCatalogue.Car);
            var trucks = vehicle.Where(truck => truck.Type == VehicleCatalogue.Truck);
            double carsAverage = cars.Any() ? cars.Average(car => car.Horsepower) : 0.0;
            double trucksAverage = trucks.Any() ? trucks.Average(truck => truck.Horsepower) : 0.0;
            Console.WriteLine($"Cars have average horsepower of: {carsAverage:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {trucksAverage:f2}.");
        }
    }
}
