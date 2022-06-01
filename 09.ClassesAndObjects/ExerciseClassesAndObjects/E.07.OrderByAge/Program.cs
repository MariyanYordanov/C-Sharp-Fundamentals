using System;
using System.Collections.Generic;
using System.Linq;

namespace E._07.OrderByAge
{
    class Program
    {
        public class Persons
        {
            public string Name { get; set; }
            public string ID { get; set; }
            public int Age { get; set; }

            public override string ToString()
            {
                return $"{Name} with ID: {ID} is {Age} years old.";
            }
        }
        static void Main(string[] args)
        {
            List<Persons> person = new List<Persons>();
            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] command = input.Split();

                string name = command[0];
                string id = command[1];
                int age = int.Parse(command[2]);

                Persons currentIPerson = person.FirstOrDefault(s => s.ID == id);
                if (currentIPerson == null)
                {
                    person.Add(new Persons()
                    {
                        Name = name,
                        ID = id,
                        Age = age,
                    });
                }
                else
                {
                    currentIPerson.Name = name;
                    currentIPerson.ID = id;
                    currentIPerson.Age = age;
                    
                }

                input = Console.ReadLine();
            }
            foreach (Persons persons in person.OrderBy(x => x.Age))
            {
                Console.WriteLine(persons);
            }
        }
    }
}
