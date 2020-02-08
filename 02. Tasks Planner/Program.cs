using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Tasks_Planner
{
    class Program
    {
        static bool CheckValidIndex(List<int> a, int index)
        {
            bool isValid = false;
            if (index >= 0 && index <= a.Count - 1)
            {
                isValid = true;
            }
            return isValid;
        }

        static void Main()
        {
            List<int> tasks = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] command = input.Split().ToArray();
                if (command[0] == "Complete")
                {
                    int index = int.Parse(command[1]);
                    if (CheckValidIndex(tasks, index)) //if -1> && tasks[index] > 0?
                    {
                        tasks.Insert(index, 0);
                        tasks.RemoveAt(index + 1);
                    }

                }

                else if (command[0] == "Change")
                {
                    int index = int.Parse(command[1]);
                    int time = int.Parse(command[2]);
                    if (CheckValidIndex(tasks, index))
                    {
                        tasks.Insert(index, time);
                        tasks.RemoveAt(index + 1);
                    }

                }
                else if (command[0] == "Drop")
                {
                    int index = int.Parse(command[1]);
                    if (CheckValidIndex(tasks, index))
                    {
                        tasks.Insert(index, -1);
                        tasks.RemoveAt(index + 1);
                    }

                }
                else if (command[0] == "Count")
                {
                    if (command[1] == "Completed")
                    {
                        int completeCounter = 0;
                        foreach (var item in tasks)
                        {
                            if (item == 0)
                            {
                                completeCounter++;
                            }

                        }

                        Console.WriteLine(completeCounter);
                    }

                    else if (command[1] == "Incomplete")
                    {
                        int incomplCounter = 0;
                        foreach (var item in tasks)
                        {
                            if (item > 0)
                            {
                                incomplCounter++;
                            }

                        }

                        Console.WriteLine(incomplCounter);
                    }

                    else if (command[1] == "Dropped")
                    {
                        int dropCounter = 0;
                        foreach (var item in tasks)
                        {
                            if (item < 0)
                            {
                                dropCounter++;
                            }

                        }
                        Console.WriteLine(dropCounter);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", tasks.Where(x => x > 0)));
        }
    }
}
