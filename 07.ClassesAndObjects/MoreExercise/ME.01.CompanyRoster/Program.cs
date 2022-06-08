using System;
using System.Collections.Generic;
using System.Linq;

namespace ME._01.CompanyRoster
{
    class Program
    {
        /// <summary>
        /// not working rigth TO DO
        /// </summary>
        public class Employee
        {
            public string Name { get; set; }
            public double Salary { get; set; }
            public string Department { get; set; }

            public Employee(string name, double salary, string department)
            {
                Name = name;
                Salary = salary;
                Department = department;
            }

            public override string ToString()
            {
                return $"{Name} {Salary:f2}";
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Employee> employeers = new List<Employee>();
            List<Employee> depart = new List<Employee>();
            double averageMax = 0;
            double sum = 0;
            string  nameDepartament = "";
            for (int i = 0; i < n; i++)
            {
                string[] cmd = Console.ReadLine().Split();

                string nameEmployeer = cmd[2];
                double salary = double.Parse(cmd[1]);
                 nameEmployeer = cmd[0];

                Employee employee = new Employee(nameEmployeer, salary, nameDepartament);
                employeers.Add(employee);
                sum += employee.Salary;
                
            }
            double average = sum / employeers.Count;
            foreach (Employee employeer in employeers.Where(x => x.Department == nameDepartament))
            {
                if (average > averageMax)
                {
                    averageMax = average;
                    depart.Add(employeer);
                }
            }
            foreach (Employee employeer in depart.OrderByDescending(x => x.Salary))
            {
                Console.WriteLine(employeer);
            }
        }
    }
    
}
 
 
