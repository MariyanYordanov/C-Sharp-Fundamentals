using System;
using System.Collections.Generic;
using System.Linq;

namespace E._03.Article2._0
{
    class Program
    {
        public class Article
        {
            private string title_;
            private string content_;
            private string author_;
           public Article(string title, string content, string author)
            {
                Title = title;
                Content = content;
                Author = author;
            }
            public string Title
            {
                get => title_;
                set => title_ = value;
            }
            public string Content
            {
                get => content_;
                set => content_ = value;
            }
            public string Author
            {
                get => author_;
                set => author_ = value;
            }


            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }

        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ");
                Article article = new Article(input[0], input[1], input[2]);
                articles.Add(article);
            }
            string criteria = Console.ReadLine();
            if (criteria == "title")
            {
                foreach (Article article in articles.OrderBy(x => x.Title))
                {
                    Console.WriteLine(article);
                }
            }
            else if (criteria == "content")
            {
                foreach (Article article in articles.OrderBy(x => x.Content))
                {
                    Console.WriteLine(article);
                }
            }
            else if (criteria == "author")
            {
                foreach (Article article in articles.OrderBy(x => x.Author))
                {
                    Console.WriteLine(article);
                }
            }
        }
    }
}
