using System;
using System.Linq;
using System.Collections.Generic;

namespace E._07.StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> studentsGrade = new Dictionary<string, List<double>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string student = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!studentsGrade.ContainsKey(student))
                {
                    studentsGrade.Add(student, new List<double>());
                }

                studentsGrade[student].Add(grade);
            }
            foreach (var item in studentsGrade.OrderByDescending(x => x.Value.Average()))
            {
                if (item.Value.Average() >= 4.50)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value.Average():f2}");
                }
                
            }
        }
    }
}
