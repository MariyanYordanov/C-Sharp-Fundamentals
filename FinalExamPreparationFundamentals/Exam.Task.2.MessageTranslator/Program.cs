using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Exam.Task._2.MessageTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"!(?<command>[A-Z][a-z]{2,})!:\[(?<message>[a-zA-Z]{8,})\]";
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    string command = match.Groups["command"].Value;
                    string message = match.Groups["message"].Value;
                    List<int> lettersList = new List<int>();
                    for (int j = 0; j < message.Length; j++)
                    {
                        int letterASCIICode = (int)message[j];
                        lettersList.Add(letterASCIICode);
                    }

                    Console.WriteLine($"{command}: {string.Join(" ", lettersList)}");
                }
                else
                {
                    Console.WriteLine("The message is invalid");
                }

            }
            
        }
    }
}
