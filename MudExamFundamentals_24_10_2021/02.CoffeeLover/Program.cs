using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.CoffeeLover
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> coffeeList = Console.ReadLine().Split().ToList();
            int numbersOfCommands = int.Parse(Console.ReadLine());
            for (int i = 0; i < numbersOfCommands; i++)
            {
                string[] commands = Console.ReadLine().Split();
                string leedCommand = commands[0];
                if (leedCommand == "Include")
                {
                    string coffee = commands[1];
                    coffeeList.Add(coffee);
                }
                else if (leedCommand == "Remove")
                {
                    string indexOfCoffeeS = commands[1];
                    int numberOfCoffeeS = int.Parse(commands[2]);
                    if (numberOfCoffeeS <= coffeeList.Count)
                    {
                        if (indexOfCoffeeS == "first")
                        {
                            coffeeList.RemoveRange(0, numberOfCoffeeS);
                        }
                        else
                        {
                            coffeeList.RemoveRange(coffeeList.Count - numberOfCoffeeS, numberOfCoffeeS);
                        }

                    }
                    
                }
                else if (leedCommand == "Prefer")
                {
                    int firstIndexCoffee = int.Parse(commands[1]);
                    int secondIndexCoffee = int.Parse(commands[2]);
                    if ((firstIndexCoffee >= 0 && firstIndexCoffee < coffeeList.Count) && (secondIndexCoffee >= 0 && secondIndexCoffee < coffeeList.Count))
                    {
                        string temp = coffeeList[secondIndexCoffee];
                        coffeeList[secondIndexCoffee] = coffeeList[firstIndexCoffee];
                        coffeeList[firstIndexCoffee] = temp;
                    }

                }
                else if (leedCommand == "Reverse")
                {
                    coffeeList.Reverse();
                }

            }

            Console.WriteLine("Coffees: ");
            Console.WriteLine(string.Join(" ",coffeeList));
        }
    }
}
