using System;

namespace _01._Guinea_Pig
{
    class Program
    {
        static void Main(string[] args)
        {
            double food = double.Parse(Console.ReadLine()) * 1000;
            double hay = double.Parse(Console.ReadLine()) * 1000;
            double cover = double.Parse(Console.ReadLine()) * 1000;
            double weight = double.Parse(Console.ReadLine()) * 1000;
            bool isEnough = true;
            for (int i = 1; i <= 30; i++)
            {
                food -= 300;
                if (food <= 0)
                {
                    isEnough = false;
                    break;
                }

                if (i % 2 == 0)
                {
                    hay -= food * 0.05;
                    if (hay <= 0)
                    {
                        isEnough = false;
                        break;
                    }
                   
                }

                if (i % 3 == 0)
                {
                    cover -= weight/3;
                    if (cover <= 0)
                    {
                        isEnough = false;
                        break;
                    }

                }

            }

            if (isEnough)
            {
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {(food / 1000):f2}, Hay: {(hay / 1000):f2}, Cover: {(cover / 1000):f2}.");
            }
            else
            {
                Console.WriteLine("Merry must go to the pet store!");
            }

        }
    }
}
