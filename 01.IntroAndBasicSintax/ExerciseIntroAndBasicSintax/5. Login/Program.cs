using System;
using System.Linq;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = new string(username.ToCharArray().Reverse().ToArray());
            string tempPass = Console.ReadLine();
            int counter = 0;

            while (tempPass != password)
            {
                counter++;

                if (counter > 3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
                Console.WriteLine("Incorrect password. Try again.");
                tempPass = Console.ReadLine();
            }

            if (tempPass == password)
            {
                Console.WriteLine($"User {username} logged in.");
            }
           
        }
    }
}
