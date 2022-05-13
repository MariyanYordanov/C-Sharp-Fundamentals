using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int spice = int.Parse(Console.ReadLine());
            
            int count = 0;
            int powerSum = 0;
            while (spice >= 100)
            {
                int power = spice;
                power -= 26;
                powerSum += power;
                count++;
                spice -= 10;
                if (spice < 100)
                {
                    powerSum -= 26;
                    break;
                }
            }
            Console.WriteLine($"{count}");
            Console.WriteLine($"{powerSum}");
            
        }
    }
}
