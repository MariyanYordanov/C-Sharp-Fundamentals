using System;

namespace _001._Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int numThree = int.Parse(Console.ReadLine());

            int maxNum = Math.Max(numOne, numTwo);
            
            if (maxNum == numOne)
            {
                int firstMax = Math.Max(numOne, numThree);
                
                if (firstMax == numOne)
                {
                    int secondMax = Math.Max(numTwo,numThree);

                    if (secondMax == numTwo)
                    {
                        int lastMax = numThree;
                        
                        Console.WriteLine($"{firstMax}\n{secondMax}\n{lastMax}");
                    }
                    else
                    {
                        int lastMax = numTwo;
                        
                        Console.WriteLine($"{firstMax}\n{secondMax}\n{lastMax}");
                    }

                }
                else
                {
                    int secondMax = Math.Max(numTwo, numOne);

                    if (secondMax == numTwo)
                    {
                        int lastMax = numOne;
                        Console.WriteLine($"{firstMax}\n{secondMax}\n{lastMax}");
                    }
                    else
                    {
                        int lastMax = numTwo;
                        Console.WriteLine($"{firstMax}\n{secondMax}\n{lastMax}");
                    }
                }
            }

            else if (maxNum == numTwo)
            {
                int firstMax = Math.Max(numTwo, numThree);

                if (firstMax == numTwo)
                {
                    int secondMax = Math.Max(numOne, numThree);

                    if (secondMax == numOne)
                    {
                        int lastMax = numThree;
                        Console.WriteLine($"{firstMax}\n{secondMax}\n{lastMax}");
                    }
                    else
                    {
                        int lastMax = numOne;
                        Console.WriteLine($"{firstMax}\n{secondMax}\n{lastMax}");
                    }
                    
                }
                else
                {
                    int secondMax = Math.Max(numTwo, numOne);

                    if (secondMax == numTwo)
                    {
                        int lastMax = numOne;
                        Console.WriteLine($"{firstMax}\n{secondMax}\n{lastMax}");
                    }
                    else
                    {
                        int lastMax = numTwo;
                        Console.WriteLine($"{firstMax}\n{secondMax}\n{lastMax}");
                    }
                }
            }
        }
    }
}
