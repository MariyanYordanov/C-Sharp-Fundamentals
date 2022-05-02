using System;
using System.Numerics;
using System.Collections.Generic;

namespace _02._Emoji_Detector
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            BigInteger multiply = 1;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] >= 48 && text[i] <= 57)
                {
                    multiply *= text[i] - 48;
                }
                
            }
            
            string[] arrText = text.Split();

            List<string> coolEmoji = new List<string>();

            for (int i = 0; i < arrText.Length; i++)
            {
                string emoji = arrText[i];

                if (emoji.Contains(","))
                {
                    string emojiRemove = "";

                    for (int j = 0; j < emoji.Length - 1; j++)
                    {
                        emojiRemove += emoji[j];
                    }
                    emoji = emojiRemove;
                    
                }
                for (int k = 0; k < emoji.Length; k++)
                {
                    if (emoji[k] >= 48 && emoji[k] <= 57)
                    {
                        emoji = "грозноЕмоджи";
                    }
                   
                }
                if (emoji.Length >= 7 && (emoji[0] == ':' && (emoji[1] == ':' && emoji[emoji.Length - 2] == ':' && emoji[emoji.Length - 1] == ':') || (emoji[0] == '*' && emoji[1] == '*' && emoji[emoji.Length - 2] == '*' && emoji[emoji.Length - 1] == '*')) && ((emoji[2] >= 65 && emoji[2] <= 90) && (emoji[emoji.Length - 3] >= 97 && emoji[emoji.Length - 3] <= 122)))
                {
                    coolEmoji.Add(emoji);
                }
            }

            List<string> coolestEmoji = new List<string>();

            for (int i = 0; i < coolEmoji.Count; i++)
            {
                string emojiSum = coolEmoji[i];

                int sum = 0;

                for (int j = 0; j < emojiSum.Length; j++)
                {
                    sum += emojiSum[j];
                }
                if (sum > multiply)
                {
                    coolestEmoji.Add(emojiSum);
                }

            }

            Console.WriteLine($"Cool threshold: {multiply}");

            Console.WriteLine($"{coolEmoji.Count} emojis found in the text. The cool ones are:");

            for (int i = 0; i < coolestEmoji.Count; i++)
            {
                Console.WriteLine(coolestEmoji[i]);
            }

        }
    }
}
