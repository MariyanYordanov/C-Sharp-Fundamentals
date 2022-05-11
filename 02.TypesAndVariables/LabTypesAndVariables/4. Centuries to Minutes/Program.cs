using System;

namespace _04._Centuries_to_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            byte centures = byte.Parse(Console.ReadLine());

            ushort years = (ushort)(centures * 100);
            int days = (int)(years * 365.2422);
            int hours = (int)(days * 24);
            ulong minutes = (ulong)(hours * 60);

            Console.WriteLine($"{centures} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
