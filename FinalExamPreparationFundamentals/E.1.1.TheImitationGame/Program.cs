using System;

namespace E._1._1.TheImitationGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string instructions = Console.ReadLine();
            while (instructions != "Decode")
            {
                string[] operations = instructions.Split("|");
                string leedOperation = operations[0];
                if (leedOperation == "Move")
                {
                    int numberOfLetters = int.Parse(operations[1]);
                    string subMessageStart = message.Substring(0, numberOfLetters);
                    message = message.Remove(0, numberOfLetters);
                    message += string.Join("", subMessageStart);
                }
                else if (leedOperation == "Insert")
                {
                    int index = int.Parse(operations[1]);
                    string value = operations[2];
                    message = message.Insert(index, value);
                }
                else if (leedOperation == "ChangeAll")
                {
                    string substring = operations[1];
                    string replacement = operations[2];
                    message = message.Replace(substring, replacement);
                }
                instructions = Console.ReadLine();
            }

            Console.WriteLine($"The decrypted message is: {message}");
        }
    }
}
