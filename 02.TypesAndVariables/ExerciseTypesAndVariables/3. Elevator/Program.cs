using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            int capasityOfElevator= int.Parse(Console.ReadLine());

            int courses = (int)Math.Ceiling((double)numOfPeople / capasityOfElevator);
            Console.WriteLine(courses);
        }
    }
}
