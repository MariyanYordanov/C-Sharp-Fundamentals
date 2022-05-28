using System;
using System.Linq;
using System.Collections.Generic;

namespace E._10.SoftUniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).ToList();

            while (true)
            {
                string[] command = Console.ReadLine().Split(":").ToArray();
                string cmd = command[0];
                if (cmd == "course start")
                {
                    break;
                }

                if (cmd == "Add")
                {
                    string lessonTitle = command[1];
                    if (!list.Contains(lessonTitle))
                    {
                        list.Add(lessonTitle);
                    }
                }

                else if (cmd == "Insert")
                {
                    string lessonTitle = command[1];
                    int index = int.Parse(command[2]);

                    if (!list.Contains(lessonTitle))
                    {
                        if (index < list.Count && index >= 0)
                        {
                            list.Insert(index, lessonTitle);
                        }
                        
                    }
                    
                }

                else if (cmd == "Remove")
                {
                    string lessonTitle = command[1];
                    string exercise = lessonTitle + "-Exercise";
                    if (list.Contains(lessonTitle))
                    {
                        list.Remove(lessonTitle);
                    }
                    if (list.Contains(exercise))
                    {
                        list.Remove(exercise);
                    }
                }
                
                else if (cmd == "Swap")
                {
                    string lessonTitle1 = command[1];
                    string lessonTitle2 = command[2];
                    int findIndex1 = list.IndexOf(lessonTitle1);
                    int findIndex2 = list.IndexOf(lessonTitle2);
                    if (findIndex1 != -1 && findIndex2 != - 1)
                    {
                        list[findIndex1] = lessonTitle2;
                        list[findIndex2] = lessonTitle1;
                        if (findIndex1 + 1 < list.Count && list[findIndex1 + 1] == $"{lessonTitle1}-Exercise")
                        {
                            list.RemoveAt(findIndex1 + 1);
                            findIndex1 = list.IndexOf(lessonTitle1);
                            list.Insert(findIndex1 + 1, $"{lessonTitle1}-Exercise");
                        }
                        if (findIndex2 + 1 < list.Count && list[findIndex2 + 1] == $"{lessonTitle2}-Exercise")
                        {
                            list.RemoveAt(findIndex2 + 1);
                            findIndex2 = list.IndexOf(lessonTitle2);
                            list.Insert(findIndex2 + 1, $"{lessonTitle2}-Exercise");
                        }


                    }
                    
                }

                else if (cmd == "Exercise")
                {
                    string lessonTitle = command[1];
                    string exercise = $"{lessonTitle}-Exercise";
                    int indexLessonTitle = list.IndexOf(lessonTitle);
                    if (list.Contains(lessonTitle) && !list.Contains(exercise))
                    {
                        list.Insert(indexLessonTitle + 1, exercise);
                    }
                    else if (!list.Contains(lessonTitle))
                    {
                        list.Add(lessonTitle);
                        list.Add(exercise);
                    }
                }

            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{list[i]}");
            }
        }
    }
}
