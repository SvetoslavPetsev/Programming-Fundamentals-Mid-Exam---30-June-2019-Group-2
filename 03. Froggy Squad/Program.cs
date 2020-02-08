using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Froggy_Squad
{
    class Program
    {
        static void Main()
        {
            List<string> frogNames = Console.ReadLine().Split(" ").ToList();

            while (true)
            {
                string[] command = Console.ReadLine().Split().ToArray();

                if (command[0] == "Print")
                {
                    if (command[1] == "Reversed")
                    {
                        frogNames.Reverse();
                    }

                    Console.WriteLine("Frogs: " + string.Join(" ", frogNames));
                    break;
                }

                else if (command[0] == "Join")
                {
                    string name = command[1];
                    frogNames.Add(name);
                }

                else if (command[0] == "Jump")
                {
                    string name = command[1];
                    int index = int.Parse(command[2]);

                    if (index >= 0 && index <= frogNames.Count - 1)
                    {
                        frogNames.Insert(index, name);
                    }

                }

                else if (command[0] == "Dive")
                {
                    int index = int.Parse(command[1]);
                    if (index >= 0 && index <= frogNames.Count - 1)
                    {
                        frogNames.RemoveAt(index);
                    }

                }
                
                else if (command[0] == "First")
                {
                    List<string> sorted = new List<string>();
                    int count = int.Parse(command[1]);
                    if (count > frogNames.Count)
                    {
                        count = frogNames.Count;
                    }

                    for (int i = 0; i < count; i++)
                    {
                        sorted.Add(frogNames[i]);
                    }

                    Console.WriteLine(string.Join(" ", sorted));
                }
                else if (command[0] == "Last")
                {
                    List<string> sorted = new List<string>();
                    int count = int.Parse(command[1]);
                    int startIndex = frogNames.Count - count;
                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }

                    for (int i = startIndex; i < frogNames.Count; i++)
                    {
                        sorted.Add(frogNames[i]);
                    }

                    Console.WriteLine(string.Join(" ", sorted));
                }
            }
        }
    }
}
