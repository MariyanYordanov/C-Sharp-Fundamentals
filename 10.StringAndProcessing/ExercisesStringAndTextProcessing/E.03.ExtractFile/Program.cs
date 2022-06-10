using System;

namespace E._03.ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("\\");
            string[] fileData = input[input.Length - 1].Split(".");
            string fileName = fileData[0];
            string fileExtention = fileData[1];
            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtention}");
        }
    }
}
