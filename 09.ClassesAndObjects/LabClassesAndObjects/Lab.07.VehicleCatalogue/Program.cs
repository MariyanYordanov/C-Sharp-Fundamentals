using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab._07.VehicleCatalogue
{
    class Program
    {
        public class Trucks
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public string Weight { get; set; }
        }

        public class Cars
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public string HorsePower { get; set; }

        }

        public class Catalog
        {
            public List<Cars> Cars { get; set; }
            public List<Trucks> Trucks { get; set; }
            public Catalog(List<Cars> car, List<Trucks> truck) 
            {
                Trucks = truck;
                Cars = car;
            }
            public void PrintCars()
            {
                Console.WriteLine("Cars:");

                foreach (Cars cars in Cars.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{cars.Brand}: {cars.Model} - {cars.HorsePower}hp");
                }
            }

            public void PrintTrucks()
            {
                Console.WriteLine("Trucks:");
                foreach (Trucks trucks in Trucks.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{trucks.Brand}: {trucks.Model} - {trucks.Weight}kg");
                }
            }
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            List<Cars> cars = new List<Cars>();
            List<Trucks> trucks = new List<Trucks>();
            Catalog vehicles = new Catalog(cars,trucks);
            while (input != "end")
            {
                string[] cmd = input.Split("/");
                string type = cmd[0];
                string brand = cmd[1];
                string model = cmd[2];
                if (type == "Car")
                {
                    string horsePower = cmd[3];
                    Cars car = new Cars()
                    {
                        Brand = brand,
                        Model = model,
                        HorsePower =horsePower
                    };

                    cars.Add(car);

                }
                else
                {
                    string weight = cmd[3];
                    Trucks truck = new Trucks()
                    {
                        Brand = brand,
                        Model = model,
                        Weight = weight
                    };

                    trucks.Add(truck);

                }

                input = Console.ReadLine();

            }

            if (cars.Count > 0)
            {
                vehicles.PrintCars();
            }
            if (trucks.Count > 0)
            {
                vehicles.PrintTrucks();
            }
        }
    }
}
