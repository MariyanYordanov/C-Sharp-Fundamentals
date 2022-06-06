using System;
using System.Collections.Generic;

namespace E._05.SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> register = new Dictionary<string, string>();
            register.Add(" "," ");
            for (int i = 0; i < n; i++)
            {
                string commands = Console.ReadLine();
                string[] cmd = commands.Split();
                string leedCmd = cmd[0];
                string username = cmd[1];
                if (leedCmd == "register")
                {
                    string licensePlateNumber = cmd[2];
                    if (!register.ContainsKey(username))
                    {
                        register.Add(username, licensePlateNumber);
                        Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                    }

                }
                else if (leedCmd == "unregister")
                {
                    if (!register.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        register.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                    
                }
                
            }
            register.Remove(" ");
            foreach (var item in register)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
