using System;

namespace _10._LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] field = new int[n];
            string[] fillField = Console.ReadLine().Split();
            for (int i = 0; i < fillField.Length; i++)
            {
                int curr = int.Parse(fillField[i]);
                field[curr] = 1;
            }
            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] token = command.Split();
                string move = token[1];
                int from = int.Parse(token[0]);
                int plus = int.Parse(token[2]);
                
                if ((from >= 0 && from <= field.Length - 1) && (field[from] == 1))
                {
                    if (move == "left")
                    {
                        int targetIndex = from - plus;
                        field[from] = 0;
                        if ((targetIndex >= 0 && targetIndex <= field.Length - 1) && field[targetIndex] == 0)
                        {
                            field[targetIndex] = 1;
                        }
                        else
                        {
                            while ((targetIndex >= 0 && targetIndex <= field.Length - 1) && field[targetIndex] == 1)
                            {
                                from = targetIndex;
                                targetIndex = from - plus;
                                if ((targetIndex >= 0 && targetIndex <= field.Length - 1) && field[targetIndex] == 0)
                                {
                                    field[targetIndex] = 1;
                                    break;
                                }
                                if (targetIndex > field.Length - 1 || targetIndex < 0)
                                {
                                    break;
                                }
                            }

                        }

                    }
                    else if (move == "right")
                    {
                        int targetIndex = from + plus;
                        field[from] = 0;
                        if ((targetIndex >= 0 && targetIndex <= field.Length - 1) && field[targetIndex] == 0)
                        {
                            field[targetIndex] = 1;
                        }
                        else 
                        {
                            while ((targetIndex >= 0 && targetIndex <= field.Length - 1) && field[targetIndex] == 1)
                            {
                                from = targetIndex;
                                targetIndex = from + plus;
                                if ((targetIndex >= 0 && targetIndex <= field.Length - 1) && field[targetIndex] == 0)
                                {
                                    field[targetIndex] = 1;
                                    break;
                                }
                                if (targetIndex > field.Length - 1 || targetIndex < 0)
                                {
                                    break;
                                }
                            }

                        }
                        
                    }
                }
                
                command = Console.ReadLine();
            }
            Console.Write(string.Join(" ",field));
        }
        private static void MitkoDes(string dad)
        {
            //int n = int.Parse(Console.ReadLine());
            //int[] field = new int[n];
            //string[] fillField = Console.ReadLine().Split();
            //for (int i = 0; i < fillField.Length; i++)
            //{
            //    int curr = int.Parse(fillField[i]);
            //    field[curr] = 1;
            //}
            //string[] token = Console.ReadLine().Split();
            //while (token[0] != "end")
            //{
            //    bool isFirst = true;
            //    int from = int.Parse(token[0]);
            //    while (from >= 0 && from < n && field[from] != 0)
            //    {
            //        if (isFirst)
            //        {
            //            field[from] = 0;
            //            isFirst = false;
            //        }

            //        string move = token[1];
            //        int to = int.Parse(token[2]);

            //        if (move == "left")
            //        {
            //            from -= to;
            //            if (from >= 0 && from < n)
            //            {
            //                if (field[from] == 0)
            //                {
            //                    field[from] = 1;
            //                    break;
            //                }
            //            }
            //        }
            //        else
            //        {
            //            from += to;
            //            if (from >= 0 && from < n)
            //            {
            //                if (field[from] == 0)
            //                {
            //                    field[from] = 1;
            //                    break;
            //                }
            //            }
            //        }
            //    }

            //    token = Console.ReadLine().Split();
            //}
            //Console.Write(string.Join(" ", field));
        }
    }
}
