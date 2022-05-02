using System;
using System.Text;

namespace E._4._1.PasswordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string commands = Console.ReadLine();
            while (commands != "Done")
            {
                string[] splitCommands = commands.Split(" ");
                string leedCommand = splitCommands[0];
                if (leedCommand == "TakeOdd")
                {
                    StringBuilder sb = new StringBuilder();
                    for (int i = 1; i < password.Length; i += 2)
                    {
                        sb.Append(password[i]);
                    }

                    password = sb.ToString();
                    Console.WriteLine(password);
                }
                else if (leedCommand == "Cut")
                {
                    int index = int.Parse(splitCommands[1]);
                    int length = int.Parse(splitCommands[2]);
                    password = password.Remove(index, length);
                    Console.WriteLine(password);
                }
                else if (leedCommand == "Substitute")
                {
                    string substring = splitCommands[1];
                    string substitute = splitCommands[2];
                    if (password.Contains(substring))
                    {
                        password = password.Replace(substring, substitute);
                        Console.WriteLine(password);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }

                commands = Console.ReadLine();
            }

            Console.WriteLine($"Your password is: {password}");
        }
    }
}
