using System;
using System.Collections.Generic;
using System.Linq;

namespace Froggy_Squad
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> frogNames = Console.ReadLine().Split().ToList();
            bool isEnd = false;

            while (true)
            {
                if (isEnd == true)
                {
                    break;
                }

                string input = Console.ReadLine();
                var arg = input.Split().ToList();

                switch (arg[0])
                {
                    case "Join":
                        string joinName = arg[1];
                        frogNames.Add(joinName);
                        break;

                    case "Jump":
                        string jumpName = arg[1];
                        int jumpIndex = int.Parse(arg[2]);
                        if (jumpIndex >= 0 && jumpIndex <= frogNames.Count - 1)
                        {
                            frogNames.Insert(jumpIndex, jumpName);
                        }
                        break;
                    case "Dive":
                        int diveIndex = int.Parse(arg[1]);
                        if (diveIndex >= 0 && diveIndex <= frogNames.Count - 1)
                        {
                            frogNames.RemoveAt(diveIndex);
                        }
                        break;

                    case "First":
                        int findex = int.Parse(arg[1]);
                        if (findex > frogNames.Count)
                        {
                            findex = frogNames.Count;
                        }
                        var ffrog = frogNames.GetRange(0, findex);
                        Console.Write(string.Join(" ", ffrog));
                        Console.WriteLine();
                        break;

                    case "Last":
                        int lindex = int.Parse(arg[1]);
                        int from = (frogNames.Count - 1) - lindex;
                        if (from < 0)
                        {
                            from = 0;
                        }
                        var lfrog = frogNames.TakeLast(lindex);
                        Console.Write(string.Join(" ", lfrog));
                        Console.WriteLine();
                        break;
                    case "Print":
                        string frogSort = arg[1];
                        if (frogSort == "Normal")
                        {
                            Console.WriteLine("Frogs: " + string.Join(" ", frogNames));
                            isEnd = true;

                        }
                        else
                        {
                            frogNames.Reverse();
                            Console.WriteLine("Frogs: " + string.Join(" ", frogNames));
                            isEnd = true;
                        }
                        break;
                }


            }
        }
    }
}