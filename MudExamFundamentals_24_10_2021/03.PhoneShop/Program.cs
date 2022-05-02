using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.PhoneShop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> phonesList = Console.ReadLine().Split(", ").ToList();
            while (true)
            {
                string[] commands = Console.ReadLine().Split(" - ");
                if (commands[0] == "End")
                {
                    break;
                }
                string leedCommand = commands[0];
                if (leedCommand == "Add")
                {
                    string phone = commands[1];
                    if (!phonesList.Contains(phone))
                    {
                        phonesList.Add(phone);
                    }
                }
                else if (leedCommand == "Remove")
                {
                    string phone = commands[1];
                    if (phonesList.Contains(phone))
                    {
                        phonesList.Remove(phone);
                    }
                }
                else if (leedCommand == "Bonus phone")
                {
                    string[] oldOrNewPhone = commands[1].Split(":");
                    string oldPhone = oldOrNewPhone[0];
                    string newPhone = oldOrNewPhone[1];
                    if (phonesList.Contains(oldPhone))
                    {
                        int findIndex = phonesList.IndexOf(oldPhone);
                        phonesList.Insert(findIndex + 1,newPhone);
                    }
                }
                else if (leedCommand == "Last")
                {
                    string phone = commands[1];
                    if (phonesList.Contains(phone))
                    {
                        int findIndex = phonesList.IndexOf(phone);
                        phonesList.Add(phone);
                        phonesList.RemoveAt(findIndex);
                    }

                }
                
            }
            Console.WriteLine(string.Join(", ",phonesList));
        }
    }
}
