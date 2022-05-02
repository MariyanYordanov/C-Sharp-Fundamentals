using System;
using System.Text;

namespace t1.ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            foreach (var letter in input)
            {
                sb.Append(letter);
            }

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Generate")
                {
                    break;
                }
                string[] cmd = command.Split(">>>",StringSplitOptions.RemoveEmptyEntries);
                if (cmd[0] == "Contains")
                {
                    string substring = cmd[1];
                    if (sb.ToString().Contains(substring))
                    {
                        Console.WriteLine($"{input} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (cmd[0] == "Flip")
                {
                    string letterCase = cmd[1];
                    int startIndex = int.Parse(cmd[2]);
                    int endIndex = int.Parse(cmd[3]);
                    for (int i = startIndex; i < endIndex; i++)
                    {
                        if (letterCase == "Upper")
                        {
                            sb.Replace(sb[i], Char.ToUpper(sb[i]), i, 1);
                        }
                        else if (letterCase == "Lower")
                        {
                            sb.Replace(sb[i], Char.ToLower(sb[i]), i, 1);
                        }

                    }

                    Console.WriteLine(sb);

                }
                else if (cmd[0] == "Slice")
                {
                    int startIndex = int.Parse(cmd[1]);
                    int endIndex = int.Parse(cmd[2]);
                    sb.Remove(startIndex, endIndex - startIndex);
                    Console.WriteLine(sb);
                }

            }
            sb.ToString();
            Console.WriteLine($"Your activation key is: {sb}");
        }
    }
}
