using System;
using System.Linq;
using System.Collections.Generic;

namespace E._06.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] cmd = input.Split(" : ");
                string courseName = cmd[0];
                string studentName = cmd[1];
                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, new List<string>());
                }
                
                courses[courseName].Add(studentName);
                input = Console.ReadLine();
            }
            foreach (var item in courses.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                Console.WriteLine($"-- {string.Join("\n-- ", item.Value.OrderBy(x => x))}");
            }
        }
    }
}
