using System;

namespace E._02.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input= Console.ReadLine().Split();
            CharacterMultiplier(input[0], input[1]);
        }

        private static void CharacterMultiplier(string firstStr, string secondStr)
        {
            string longer = "";
            string smaller = "";
            if (firstStr.Length > secondStr.Length)
            {
                longer = firstStr;
                smaller = secondStr;
            }
            else
            {
                longer = secondStr;
                smaller = firstStr;
            }
            string remander = longer.Substring(smaller.Length);
            int multiplier = 0;
            for (int i = 0; i < smaller.Length; i++)
            {
                multiplier += longer[i] * smaller[i];
            }
            foreach (var item in remander)
            {
                multiplier += item;
            }
            Console.WriteLine(multiplier);
        }
    }
}
