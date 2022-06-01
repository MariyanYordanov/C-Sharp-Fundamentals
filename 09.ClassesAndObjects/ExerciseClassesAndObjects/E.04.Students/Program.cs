using System;
using System.Collections.Generic;
using System.Linq;

namespace E._04.Students
{
    class Program
    {
        public class Student
        {
            public string FirstName { get; set; } 
            public string LastName { get; set; }
            public double Grade { get; set; }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split(" ");
                Student student = new Student();
                student.FirstName = info[0];
                student.LastName = info[1];
                student.Grade = double.Parse(info[2]);
                students.Add(student);
            }
            
            foreach (Student student in students.OrderBy(x => x.Grade).Reverse())
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            }
        }
    }
}
