using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab._04.Students
{
    class Program
    {
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

                Student student = new Student()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    City = city
                };

                students.Add(student);
                line = Console.ReadLine();
            }
            string filterCity = Console.ReadLine();
            foreach (Student student in students.Where(s => s.City == filterCity).ToList())
            {
                Console.WriteLine($"{ student.FirstName} { student.LastName} is { student.Age } years old.");
            }
        }
    }
    
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }
}
