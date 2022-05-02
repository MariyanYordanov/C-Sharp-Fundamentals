using System;
using System.Text;

namespace E._4._1._1.SecretChat
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string commands = Console.ReadLine();
            while (commands != "Reveal")
            {
                string[] cmd = commands.Split(":|:");
                string leedCommand = cmd[0];
                if (leedCommand == "InsertSpace")
                {
                    int index = int.Parse(cmd[1]);
                    message = message.Insert(index, " ");
                    Console.WriteLine(message);
                }
                else if (leedCommand == "Reverse")
                {
                    string substring = cmd[1];
                    if (message.Contains(substring))
                    {
                        StringBuilder cb = new StringBuilder();
                        for (int i = substring.Length - 1; i >= 0; i--)
                        {
                            cb.Append(substring[i]);
                        }
                        string reversedSub = cb.ToString();
                        int findIndex = message.IndexOf(substring);
                        message = message.Remove(findIndex, substring.Length);
                        message = message.Insert(message.Length, reversedSub);
                        Console.WriteLine(message);
                        cb.Clear();
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (leedCommand == "ChangeAll")
                {
                    string substring = cmd[1];
                    string replacement = cmd[2];
                    message = message.Replace(substring, replacement);
                    Console.WriteLine(message);
                }
                commands = Console.ReadLine();
            }

            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
