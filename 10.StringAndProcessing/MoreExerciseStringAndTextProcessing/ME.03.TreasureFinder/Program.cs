using System;
using System.Linq;
using System.Text;


namespace ME._03.TreasureFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] key = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string input = Console.ReadLine();
            
            while (input != "find")
            {
                StringBuilder sb = new StringBuilder();
                int a = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    if (a == key.Length)
                    {
                        a = 0;
                    }
                    int uncode = input[i] - key[a];
                    char addLetter = Convert.ToChar(uncode);
                    sb.Append(addLetter);
                    a++;

                }

                string text = sb.ToString();
                int startIndexType = text.IndexOf('&');
                int endIndexType = 0;
                for (int i = startIndexType + 1; i < text.Length; i++)
                {
                    if (text[i] == '&')
                    {
                        endIndexType = i;
                        break;
                    }

                }

                string type = text.Substring(startIndexType + 1, endIndexType - startIndexType - 1);
                int startIndexCoordinates = text.IndexOf('<');
                int endIndexCoordinates = text.IndexOf('>');
                string coordinates = text.Substring(startIndexCoordinates + 1, endIndexCoordinates - startIndexCoordinates - 1);
                Console.WriteLine($"Found {type} at {coordinates}");
                input = Console.ReadLine();
            }
            
        }

    }
}
