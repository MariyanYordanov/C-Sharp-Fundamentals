using System;

namespace _04.PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            PasswordValidator(password);
        }

        private static void PasswordValidator(string input)
        {
            
            if (!CorrectNumberOfCharacters(input))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            
            if (!CharactersCheck(input))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!DigitCheck(input))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (CorrectNumberOfCharacters(input) && CharactersCheck(input) && DigitCheck(input))
            {
                Console.WriteLine("Password is valid");
            }
            
        }

        private static bool DigitCheck(string input)
        {
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsDigit(input[i]))
                {
                    count++;
                }
            }
            if (count < 2)
            {
                return false;
            }
            return true;

            //return count >= 2; - вместо ифа за каунт по малко от две
        }

        private static bool CharactersCheck(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (!Char.IsLetterOrDigit(input[i]))
                {
                    return false;
                }
            }
            return true;
        }

        private static bool CorrectNumberOfCharacters(string input)
        {
            return input.Length >= 6 && input.Length <= 10; 
        }
    }
}
