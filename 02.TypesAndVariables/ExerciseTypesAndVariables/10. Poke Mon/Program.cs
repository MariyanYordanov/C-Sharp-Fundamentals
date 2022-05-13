using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            int countPoke = 0;
            int halfPower = (int)(power * 0.5);

            while (power >= distance)
            {
                power -= distance;
                countPoke++;

                if (power == halfPower && exhaustionFactor > 0)
                {
                    power = (int)(power / exhaustionFactor);
                }
            }
            Console.WriteLine(power);
            Console.WriteLine(countPoke);
        }
    }
}
