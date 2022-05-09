using System;

namespace _03._Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());
            string buyGames = Console.ReadLine();
            double balance = 0;
            while (buyGames != "Game Time")
            {
                if (buyGames == "OutFall 4")
                {
                    if (currentBalance >= 39.99)
                    {
                        currentBalance -= 39.99;
                        balance += 39.99;
                        Console.WriteLine($"Bought {buyGames}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (buyGames == "RoverWatch Origins Edition")
                {
                    if (currentBalance >= 39.99)
                    {
                        currentBalance -= 39.99;
                        balance += 39.99;
                        Console.WriteLine($"Bought {buyGames}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (buyGames == "CS: OG")
                {
                    if (currentBalance >= 15.99)
                    {
                        currentBalance -= 15.99;
                        balance += 15.99;
                        Console.WriteLine($"Bought {buyGames}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (buyGames == "Zplinter Zell")
                {
                    if (currentBalance >= 19.99)
                    {
                        currentBalance -= 19.99;
                        balance += 19.99;
                        Console.WriteLine($"Bought {buyGames}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (buyGames == "Honored 2")
                {
                    if (currentBalance >= 59.99)
                    {
                        currentBalance -= 59.99;
                        balance += 59.99;
                        Console.WriteLine($"Bought {buyGames}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (buyGames == "RoverWatch")
                {
                    if (currentBalance >= 29.99)
                    {
                        currentBalance -= 29.99;
                        balance += 29.99;
                        Console.WriteLine($"Bought {buyGames}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else
                {
                    Console.WriteLine("Not Found");
                }
                
                buyGames = Console.ReadLine();

                if (currentBalance <= 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
                
            }

            Console.WriteLine($"Total spent: ${balance:f2}. Remaining: ${currentBalance:f2}");

        }
    }
}
