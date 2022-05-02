using System;

namespace Exam.Task._1.StringManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string receivedString = Console.ReadLine();
            string commands = Console.ReadLine();
            while (commands != "End")
            {
                string[] command = commands.Split();
                string leedComand = command[0];
                if (leedComand == "Translate")
                {
                    string letter = command[1];
                    string replacement = command[2];
                    receivedString = receivedString.Replace(letter, replacement);
                    Console.WriteLine(receivedString);
                }
                else if (leedComand == "Includes")
                {
                    string subString = command[1];
                    if (receivedString.Contains(subString))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }

                }
                else if (leedComand == "Start")
                {
                    string subString = command[1];
                    if (receivedString.StartsWith(subString))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }

                }
                else if (leedComand == "Lowercase")
                {
                    receivedString = receivedString.ToLower().ToString();
                    Console.WriteLine(receivedString);
                }
                else if (leedComand == "FindIndex")
                {
                    char letter = char.Parse(command[1]);
                    int findedIndex = receivedString.LastIndexOf(letter);
                    Console.WriteLine(findedIndex);
                }
                else if (leedComand == "Remove")
                {
                    int startIndex = int.Parse(command[1]);
                    int count = int.Parse(command[2]);
                    receivedString = receivedString.Remove(startIndex, count);
                    Console.WriteLine(receivedString);
                }

                commands = Console.ReadLine();
            }
        }
    }
}
