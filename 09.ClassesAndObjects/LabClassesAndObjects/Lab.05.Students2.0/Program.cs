using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab._05.Students2._0
{
    class Program
    {
        class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string City { get; set; }
        }
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string line = Console.ReadLine();
            while (line != "end")
            {
                string[] cmd = line.Split();

                string firstName = cmd[0];
                string lastName = cmd[1];
                int age = int.Parse(cmd[2]);
                string city = cmd[3];

                Student student = students.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName); // solution whit LINQ  whitout 2 extra methods for checking students - IsStudentExisting and GetStudent
                if (student == null)
                {
                    students.Add(new Student()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        City = city
                    });
                }
                else
                {
                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.City = city;
                }
                line = Console.ReadLine();
            }
            string input = Console.ReadLine();
            foreach (Student student in students)
            {
                if (student.City == input)
                {
                    Console.WriteLine($"{ student.FirstName} { student.LastName} is { student.Age } years old.");
                }
            }
        }
    }
}
