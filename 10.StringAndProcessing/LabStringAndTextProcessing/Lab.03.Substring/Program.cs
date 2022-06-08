using System;

namespace Lab._03.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstString = Console.ReadLine();
            string secondString = Console.ReadLine();
            string temp = secondString;
            int findIndex = temp.IndexOf(firstString);
            while (findIndex >= 0)
            {
                string reOrganizedString = temp.Remove(findIndex, firstString.Length);
                temp = reOrganizedString;
                findIndex = temp.IndexOf(firstString);
            }

            Console.WriteLine(temp);
        }
    }
}
