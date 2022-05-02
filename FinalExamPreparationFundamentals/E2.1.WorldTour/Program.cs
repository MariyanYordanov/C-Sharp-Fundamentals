using System;

namespace E2._1.WorldTour
{
    class Program
    {
        static void Main(string[] args)
        {
            string stops = Console.ReadLine();
            string commands = Console.ReadLine();
            while (commands != "Travel")
            {
                string[] cmd = commands.Split(":");
                string leedCommand = cmd[0];
                if (leedCommand == "Add Stop")
                {
                    int index = int.Parse(cmd[1]);
                    string text = cmd[2];
                    if (index >= 0 && index <= stops.Length - 1)
                    {
                        stops = stops.Insert(index, text);
                    }

                    Console.WriteLine(stops);
                }
                else if (leedCommand == "Remove Stop")
                {
                    int startIndex = int.Parse(cmd[1]);
                    int endIndex = int.Parse(cmd[2]);
                    if ((startIndex >= 0 && startIndex <= stops.Length - 1) && (endIndex >= 0 && endIndex <= stops.Length - 1))
                    {
                        stops = stops.Remove(startIndex, endIndex - startIndex + 1);
                    }

                    Console.WriteLine(stops);
                }
                else if (leedCommand == "Switch")
                {
                    string oldText = cmd[1];
                    string newText = cmd[2];
                    if (stops.Contains(oldText))
                    {
                        stops = stops.Replace(oldText, newText);
                    }

                    Console.WriteLine(stops);
                }

                commands = Console.ReadLine();
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
        }
    }
}
