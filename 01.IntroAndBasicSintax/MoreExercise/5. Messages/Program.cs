using System;

namespace _05._Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string word = string.Empty;

            for (int i = 1; i <= number; i++)
            {
                string num = Console.ReadLine();
                char n = num[0];
                
                if (n == '2')
                {
                    if (num.Length == 1)
                    {
                        word += 'a';
                    }
                    else if (num.Length == 2)
                    {
                        word += 'b';
                    }
                    else
                    {
                        word += 'c';
                    }
                }

                else if (n == '3')
                {
                    if (num.Length == 1)
                    {
                        word += 'd';
                    }
                    else if (num.Length == 2)
                    {
                        word += 'e';
                    }
                    else
                    {
                        word += 'f';
                    }
                }

                else if (n == '4')
                {
                    if (num.Length == 1)
                    {
                        word += 'g';
                    }
                    else if (num.Length == 2)
                    {
                        word += 'h';
                    }
                    else
                    {
                        word += 'i';
                    }
                }

                else if (n == '5')
                {
                    if (num.Length == 1)
                    {
                        word += 'j';
                    }
                    else if (num.Length == 2)
                    {
                        word += 'k';
                    }
                    else
                    {
                        word += 'l';
                    }
                }

                else if (n == '6')
                {
                    if (num.Length == 1)
                    {
                        word += 'm';
                    }
                    else if (num.Length == 2)
                    {
                        word += 'n';
                    }
                    else
                    {
                        word += 'o';
                    }
                }

                else if (n == '7')
                {
                    if (num.Length == 1)
                    {
                        word += 'p';
                    }
                    else if (num.Length == 2)
                    {
                        word += 'q';
                    }
                    else if (num.Length == 3)
                    {
                        word += 'r';
                    }
                    else
                    {
                        word += 's';
                    }
                }

                else if (n == '8')
                {
                    if (num.Length == 1)
                    {
                        word += 't';
                    }
                    else if (num.Length == 2)
                    {
                        word += 'u';
                    }
                    else
                    {
                        word += 'v';
                    }
                }

                else if (n == '9')
                {
                    if (num.Length == 1)
                    {
                        word += 'w';
                    }
                    else if (num.Length == 2)
                    {
                        word += 'x';
                    }
                    else if (num.Length == 3)
                    {
                        word += 'y';
                    }
                    else
                    {
                        word += 'z';
                    }
                }

                else if (n == '0')
                {
                    word += " ";
                }

                
            }
            Console.WriteLine(word);
        }
    }
}
