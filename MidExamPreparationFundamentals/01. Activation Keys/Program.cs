using System;
using System.Collections.Generic;

namespace _01._Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<char> activationKey = new List<char>();
            for (int i = 0; i < input.Length; i++)
            {
                activationKey.Add(input[i]);
            }
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Generate")
                {
                    break;
                }
                string[] token = command.Split(">>>");
                string word = token[0];
                if (word == "Contains")
                {
                    string substring = token[1];
                    string sub = "";
                    for (int i = 0; i < activationKey.Count - substring.Length + 1; i++)
                    {
                        if (substring[0] == activationKey[i])
                        {
                            for (int j = 0; j < substring.Length; j++)
                            {
                                sub += substring[j];
                            }
                            break;
                        }
                    }
                    if (sub == substring)
                    {
                        Console.WriteLine($"{string.Join("", activationKey)} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine($"Substring not found!");
                    }
                }
                else if (word == "Flip")
                {
                    string letterCase = token[1];
                    int startIndex = int.Parse(token[2]);
                    int endIndex = int.Parse(token[3]);
                    if (letterCase == "Lower")
                    {
                        for (int i = startIndex; i < endIndex; i++)
                        {
                            activationKey[i] = Char.ToLower(activationKey[i]);
                        }
                    }
                    else
                    {
                        for (int i = startIndex; i < endIndex; i++)
                        {
                            activationKey[i] = Char.ToUpper(activationKey[i]);
                        }
                    }
                    Console.WriteLine(string.Join("", activationKey));
                }
                else if (word == "Slice")
                {
                    int startIndex = int.Parse(token[1]);
                    int endIndex = int.Parse(token[2]);
                    int range = endIndex - startIndex;
                    activationKey.RemoveRange(startIndex, range);

                    Console.WriteLine(string.Join("", activationKey));
                }
            }

            Console.WriteLine($"Your activation key is: {string.Join("", activationKey)}");
        }
    }
}
