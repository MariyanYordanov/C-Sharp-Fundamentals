using System;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace StringAndTextProcessing
{
    class Program
    {

        static void Main(string[] args)
        {

            string fruits = "banana, kiwi, banana, apple";

            // IndexOf() - returns the first match index or - 1​

            int findIndex = fruits.IndexOf("banana"); //0​

            int findIndes2 = fruits.IndexOf("orange"); //-1​

            //===================================================================

            // LastIndexOf() - finds the last occurrence​

            int findLastIndex = fruits.LastIndexOf("banana"); // 21

            int findLastIndex2 = fruits.LastIndexOf("orange"); // -1

            // =========================================================

            // Substring(int startIndex, int length)​

            string card = "10C";

            string power = card.Substring(0, 2);

            Console.WriteLine(power); //10​

            //==========================================

            // Substring(int startIndex)​

            string text = "My name is John";

            string extractWord = text.Substring(11);

            Console.WriteLine(extractWord); //John​

            //==========================================

            // Contains() - Check whether one string contains other string

            string text2 = "I love fruits.";

            Console.WriteLine(text2.Contains("fruits")); //True​

            Console.WriteLine(text2.Contains("banana")); //False​

            //=======================================================

            // Split() a string by given separator​

            string text3 = "Hello, john@softuni.bg, you have been using​ john @softuni.bg in your registration";

            string[] words = text3.Split(", ");

            Console.WriteLine(words);

            // words[]:​

            // "Hello"​

            // "john@softuni.bg"​

            // "you have been using john@softuni.bg in your registration"

            //=====================================================================

            // Split can be used with multiple separators​

            char[] separators = new char[] { ' ', ',', '.' };

            string text4 = "Hello, I am John.";

            string[] words2 = text4.Split(separators);

            Console.WriteLine(words2);

            // "Hello", "", "I", "am", "John", ""​

            //=====================================

            // Using StringSplitOptions.RemoveEmptyEntries to ​remove empty array elements from the array returned​

            char[] separators1 = new char[] { ' ', ',', '.' };

            string text5 = "Hello, I am John.";

            string[] words3 = text5.Split(separators1, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine(words3);

            // "Hello", "I", "am", "John"​

            //====================================

            // Replace(match, replacement) - replaces all occurrences ​The result is a new string(strings are immutable)​

            string text6 = "Hello, john@softuni.bg, you have been using john@ softuni.bg in your registration.";

            string replacedText = text6​.Replace("john@softuni.bg", "john@softuni.com");


            Console.WriteLine(replacedText);

            // Output:​

            // Hello, john@softuni.com, you have been using john@softuni.com in your registration.​

            //======================================================================================

            // Use the StringBuilder to build / modify strings​

            StringBuilder sb = new StringBuilder();

            sb.Append("Hello, ");

            sb.Append("John!");

            // output 

            // Hello, John!

            //===============================================

            // Concatenating strings is a slow operation because each​ iteration creates a new string​

            Stopwatch sw = new Stopwatch();

            sw.Start();

            string text10 = "";

            for (int i = 0; i < 20000; i++)
            {
                text10 += i;
            }
            sw.Stop();

            Console.WriteLine(sw.ElapsedMilliseconds); //73625​

            // Using StringBuilder

            Stopwatch sw1 = new Stopwatch();

            sw.Start();

            StringBuilder text11 = new StringBuilder();

            for (int i = 0; i < 20000; i++)
            {
                text11.Append(i);
            }

            sw.Stop();

            Console.WriteLine(sw.ElapsedMilliseconds);//16​

            //==================================================

            // Append(…) – add text or a string representation of an object​ to the end of a string​

            StringBuilder sb2 = new StringBuilder();

            sb2.Append("Hello Peter, how are you?");

            // Length – holds the length of the string in the buffer​

            sb2.Append("Hello Peter, how are you?");

            Console.WriteLine(sb2.Length); // 32​

            // Clear(…) – removes all characters​

            //=====================================

            // [int index] – return char on current index​

            StringBuilder sb3 = new StringBuilder();

            sb3.Append("Hello Peter, how are you?");

            Console.WriteLine(sb3[1]); // e​

            // Insert(int index, string str) – inserts a string​ at the specified character position​

            sb3.Insert(11, " Ivanov");

            Console.WriteLine(sb3); // Hello Peter Ivanov, how are you? ​

            // Replace(string oldValue, string newValue) – ​replaces all occurrences of a specified string with another ​specified string​

            sb3.Append("Hello Peter, how are you?");

            sb3.Replace("Peter", "George");

            //     ТoString() – converts the value of this instance to a String​

            string text12 = sb.ToString();

            Console.WriteLine(text12);

            //Hello George, how are you?​
        }
    }
}
