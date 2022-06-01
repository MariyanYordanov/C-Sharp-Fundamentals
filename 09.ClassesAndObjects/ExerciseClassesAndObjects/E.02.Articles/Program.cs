using System;

namespace E._02.Articles
{
    class Program
    {
        public class Article
        {
            private string title_;
            private string content_;
            private string author_;
            public Article( string title, string content, string author)
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


            public void Rename(string title)
            {
                Title = title;
            }
            public  void Edit(string content)
            {
                Content = content;
            }

            public void ChangeAuthor(string author)
            {
                Author = author;
            }


            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }

        }
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            Article article = new Article(input[0], input[1], input[2]); 
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] cmd = Console.ReadLine().Split(": ");
                string token = cmd[0];
                string argument = cmd[1];
                if (token == "Rename")
                {
                    article.Rename(argument);
                }
                else if (token == "Edit")
                {
                    article.Edit(argument); 
                }
                else if (token == "ChangeAuthor")
                {
                    article.ChangeAuthor(argument);
                }
            }

            Console.WriteLine(article);

        }
    }
}
