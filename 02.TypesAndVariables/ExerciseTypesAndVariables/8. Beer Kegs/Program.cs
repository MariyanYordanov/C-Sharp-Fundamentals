using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double biggerKeg = double.MinValue;
            string firstModel = string.Empty;

            for (int i = 1; i <= n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = (double)(Math.PI * Math.Pow(radius,2) * height);

                if (volume >= biggerKeg)
                {
                    biggerKeg = volume;
                    firstModel = model;
                }
            }
            Console.WriteLine(firstModel);
        }
    }
}
