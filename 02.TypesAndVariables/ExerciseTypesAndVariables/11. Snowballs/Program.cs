using System;
using System.Numerics;

namespace _11._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger snowballSnow = 0;
            BigInteger snowballTime = 0;
            int snowballQuality = 0;
            
            BigInteger snowballValue = int.MinValue;

            for (int i = 1; i <= n; i++)
            {
                BigInteger snow = BigInteger.Parse(Console.ReadLine());
                BigInteger time = BigInteger.Parse(Console.ReadLine());
                int quality = int.Parse(Console.ReadLine());
                BigInteger result = snow / time;
                BigInteger value = BigInteger.Pow(result, quality);

                if (value >= snowballValue)
                {
                    snowballValue = value;
                    snowballSnow = snow;
                    snowballTime = time;
                    snowballQuality = quality;
                }
            }
            Console.WriteLine($"{snowballSnow} : {snowballTime} = {snowballValue} ({snowballQuality})");
        }
    }
}
