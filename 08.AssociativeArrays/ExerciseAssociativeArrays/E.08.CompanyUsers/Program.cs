using System;
using System.Linq;
using System.Collections.Generic;

namespace _08.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companyID = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] cmd = input.Split(" -> ");
                string companyName = cmd[0];
                string employeeId = cmd[1];
                if (!companyID.ContainsKey(companyName))
                {
                    companyID.Add(companyName, new List<string>());
                }
                
                if (!companyID[companyName].Contains(employeeId))
                {
                    companyID[companyName].Add(employeeId);
                }

                input = Console.ReadLine();
            }

            foreach (var item in companyID.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}");
                foreach (var employeeId in item.Value)
                {
                    Console.WriteLine($"-- {employeeId}");
                }
                //Console.WriteLine($"-- {string.Join("\n-- ", item.Value.OrderBy(x => x))}"); - not working !!
            }
        }
    }
}
