using System;

namespace ME._01.ExtractPersonInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                int startIndexName = input.IndexOf('@');
                int endIndexName = input.IndexOf('|');
                int startIndexAge = input.IndexOf('#');
                int endIndexAge = input.IndexOf('*');
                string name = "";
                string age = "";
                
                if (startIndexName >= 0 && endIndexName >= 0)
                {
                    name = input.Substring(startIndexName + 1, endIndexName - startIndexName - 1);
                }

                if (startIndexAge >= 0 && endIndexAge >= 0)
                {
                    age = input.Substring(startIndexAge + 1, endIndexAge - startIndexAge - 1);
                }

                Console.WriteLine($"{name} is {age} years old.");
            }
            
        }
    }
}
