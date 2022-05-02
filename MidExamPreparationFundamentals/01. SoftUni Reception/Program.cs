using System;

namespace _01._SoftUni_Reception
{
    class Program
    {
        static void Main(string[] args)
        {
            int efficiencyFirstEmployee = int.Parse(Console.ReadLine());
            int efficiencySecondEmployee = int.Parse(Console.ReadLine());
            int efficiencyThirdEmployee = int.Parse(Console.ReadLine());
            int questions = int.Parse(Console.ReadLine());
            int answerPerHour = efficiencyFirstEmployee + efficiencySecondEmployee + efficiencyThirdEmployee;
            int time = 0;
            while (questions > 0)
            {
                questions -= answerPerHour;
                time++;
                if (time % 4 == 0)
                {
                    questions += answerPerHour;
                }
                
            }
            Console.WriteLine($"Time needed: {time}h.");
        }
    }
}
