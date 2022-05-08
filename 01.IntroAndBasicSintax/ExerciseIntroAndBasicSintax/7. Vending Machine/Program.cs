using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            double sumMoney = 0;

            while (input != "start")
            {
                double money = double.Parse(input);

                if (money == 1 || money == 2 || money == 0.2 || money == 0.1 || money == 0.5)
                {
                    sumMoney += money; 
                }
                else
                {
                    Console.WriteLine($"Cannot accept {money}");
                }

                input = Console.ReadLine().ToLower();
            }

            string text = Console.ReadLine().ToLower();

            while (text != "end")
            {
                if (text == "nuts")
                {
                    sumMoney -= 2.0;

                    if (sumMoney >= 0)
                    {
                        Console.WriteLine($"Purchased {text}");
                    }

                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                        sumMoney += 2.0;
                    }
                }

                else if (text == "water")
                {
                    sumMoney -= 0.7;

                    if (sumMoney >= 0)
                    {
                        Console.WriteLine($"Purchased {text}");
                    }

                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                        sumMoney += 0.7;
                    }
                }

                else if (text == "crisps")
                {
                    sumMoney -= 1.5;

                    if (sumMoney >= 0)
                    {
                        Console.WriteLine($"Purchased {text}");
                    }

                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                        sumMoney += 1.5;
                    }
                }

                else if (text == "soda")
                {
                    sumMoney -= 0.8;

                    if (sumMoney >= 0)
                    {
                        Console.WriteLine($"Purchased {text}");
                    }

                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                        sumMoney += 0.8;
                    }
                }

                else if (text == "coke")
                {
                    sumMoney -= 1.0;

                    if (sumMoney >= 0)
                    {
                        Console.WriteLine($"Purchased {text}");
                    }

                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                        sumMoney += 1;
                    }
                }

                else
                {
                    Console.WriteLine("Invalid product");    
                }
                text = Console.ReadLine().ToLower();
            }

            if (sumMoney >= 0)
            {
                Console.WriteLine($"Change: {sumMoney:f2}");
            }
        }
    }
}
