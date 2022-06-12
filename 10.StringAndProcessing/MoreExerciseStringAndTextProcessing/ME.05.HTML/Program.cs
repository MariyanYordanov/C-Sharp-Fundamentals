using System;

namespace ME._05.HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string titleOfArticle = Console.ReadLine();
            Console.WriteLine($"<h1>\n    {titleOfArticle}\n</h1>");
            string contentOfArticle = Console.ReadLine();
            Console.WriteLine($"<article>\n    {contentOfArticle}\n</article>");
            string commentsAboutArticle = Console.ReadLine();
            while (commentsAboutArticle != "end of comments")
            {
                Console.WriteLine($"<div>\n    {commentsAboutArticle}\n</div>");
                commentsAboutArticle = Console.ReadLine();
            }
        }
    }
}
