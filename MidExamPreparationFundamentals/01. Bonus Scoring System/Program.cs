using System;

namespace _01._Bonus_Scoring_System
{
    class Program
    {
        static void Main(string[] args)
        {
            double numbersOfStudents = double.Parse(Console.ReadLine());
            double numberOfLectors = double.Parse(Console.ReadLine());
            double additionalBonus = double.Parse(Console.ReadLine());
            double max = 0;
            double attendances = 0;
            
            for (int i = 0; i < numbersOfStudents; i++)
            {
                
                double studentAttendances = double.Parse(Console.ReadLine());
                double totalBonus = studentAttendances / numberOfLectors * (5 + additionalBonus );
                if (totalBonus > max)
                {
                    max = totalBonus;
                    attendances = studentAttendances;
                }

            }
            Console.WriteLine($"Max Bonus: {Math.Ceiling(max)}.");
            Console.WriteLine($"The student has attended {attendances} lectures.");
        }
    }
}
