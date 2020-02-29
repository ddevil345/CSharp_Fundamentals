using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Archery_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split('|').Select(int.Parse).ToList();
            int points = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Game Over")
                {
                    break;
                }
                if (input == "Reverse")
                {
                    targets.Reverse();
                    break;
                }
                var arr = input.Split('@').ToList();

                Console.WriteLine($"arr0:{arr[0]}| arr1:{arr[1]}| arr2:{arr[2]}|");

                if (arr[0] == "Shoot Left")
                {
                    int index = int.Parse(arr[1]);
                    int count = int.Parse(arr[2]);
               
                    if (index >= 0 && index < targets.Count)
                    {
                        for (int i = index; i < count; i++)
                        {
                            index--;
                            if (index == -1)
                            {
                                index = targets.Count - 1;
                            }
                        }
                        if (targets[index] >= 5)
                        {
                            targets[index] -= 5;
                            points += 5;
                        }
                        else if (targets[index] > 0)
                        {
                            points += targets[index];
                            targets[index] = 0;
                        }
                    }

                }
                if (arr[0] == "Shoot Right")
                {
                    int index = int.Parse(arr[1]);
                    int count = int.Parse(arr[2]);

                    if (index >= 0 && index < targets.Count)
                    {
                        for (int i = index; i < count; i++)
                        {
                            index++;
                            if (index == targets.Count)
                            {
                                index = 0;
                            }
                        }
                        if (targets[index] >= 5)
                        {
                            targets[index] -= 5;
                            points += 5;
                        }
                        else if (targets[index] > 0)
                        {
                            points += targets[index];
                            targets[index] = 0;
                        }
                    }

                }


            }
            Console.WriteLine(string.Join(" - ",targets));
            Console.WriteLine($"Iskren finished the archery tournament with {points} points!");
        }
    }
}
