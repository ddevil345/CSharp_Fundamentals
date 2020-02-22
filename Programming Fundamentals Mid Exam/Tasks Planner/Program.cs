using System;
using System.Collections.Generic;
using System.Linq;

namespace Tasks_Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> timesTasks = Console.ReadLine().Split().ToList();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                var tasks = input.Split().ToList();

                switch (tasks[0])
                {
                    case "Complete":
                        int index = int.Parse(tasks[1]);
                        if (index >= 0 && index <= timesTasks.Count - 1)
                        {
                            timesTasks[index] = "0";
                        }
                        break;
                    case "Change":
                        int indexChange = int.Parse(tasks[1]);
                        int timeCahnge = int.Parse(tasks[2]);
                        if (indexChange >= 0 && indexChange <= timesTasks.Count - 1)
                        {
                            if (timeCahnge >= 1 && timeCahnge <= 5)
                            {
                                timesTasks[indexChange] = timeCahnge.ToString();
                            }
                        }
                        break;
                    case "Drop":
                        int indexDrop = int.Parse(tasks[1]);
                        if (indexDrop >= 0 && indexDrop <= timesTasks.Count - 1)
                        {
                            timesTasks[indexDrop] = "-1";
                        }
                        break;
                    case "Count":
                        string arg = tasks[1];

                        if (arg == "Completed")
                        {
                            int completed = 0;
                            foreach (var item in timesTasks)
                            {

                                if (int.Parse(item) == 0)
                                {
                                    completed++;
                                }

                            }
                            Console.WriteLine(completed);
                        }
                        else if (arg == "Incomplete")
                        {
                            int incomplete = 0;
                            foreach (var item in timesTasks)
                            {

                                if (int.Parse(item) > 0)
                                {
                                    incomplete++;
                                }

                            }
                            Console.WriteLine(incomplete);

                        }
                        else if (arg == "Dropped")
                        {
                            int dropped = 0;
                            foreach (var item in timesTasks)
                            {

                                if (int.Parse(item) < 0)
                                {
                                    dropped++;
                                }

                            }
                            Console.WriteLine(dropped);
                        }

                        break;
                }

            }

            foreach (var item in timesTasks)
            {
                if (int.Parse(item) > 0)
                {
                    Console.Write(item + " ");
                }
            }
        }
    }
}