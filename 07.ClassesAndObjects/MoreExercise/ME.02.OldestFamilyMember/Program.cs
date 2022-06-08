using System;
using System.Linq;
using System.Collections.Generic;

namespace ME._02.OldestFamilyMember
{
    class Program
    {
        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        class Family
        {
            List<Person> members = new List<Person>();
            public void AddMember(Person member)
            {
                members.Add(member);
            }
            public Person GetOldestMember(List<Person> members)
            {
                return members.OrderByDescending(x => x.Age).FirstOrDefault();
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                Person member = new()
                {
                    Name = input[0],
                    Age = int.Parse(input[1])
                };

                family.AddMember(member);
            }
            // to do
            //Person olddestMember = family.GetOldestMember();
            //Console.WriteLine($"{0}{1}",olddestMember.Name, olddestMember.Age);
        }
    }
}
