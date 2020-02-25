using System;
using System.Collections.Generic;
using System.Linq;


namespace _02._Friendlist_Maintenance
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split(", ").ToList();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Report")
                {
                    break;
                }
                var arr = input.Split().ToList();

                switch (arr[0])
                {
                    case "Blacklist":
                        var nameBlackList = arr[1];
                        int idx = names.FindIndex(x => x == nameBlackList);
                        if (idx != -1)
                        {
                            names[idx] = "Blacklisted";
                            Console.WriteLine($"{nameBlackList} was blacklisted.");

                        }
                        else
                        {
                            Console.WriteLine($"{nameBlackList} was not found.");
                        }
                        break;
                    case "Error":
                        int indexErr = int.Parse(arr[1]);                      
                        if (names[indexErr] != "Blacklisted" && names[indexErr] != "Lost")
                        {
                            var nameErr = names[indexErr];
                            names[indexErr] = "Lost";
                            Console.WriteLine($"{nameErr} was lost due to an error.");
                        }
                        break;
                    case "Change":
                        int indexCh = int.Parse(arr[1]);
                        var newName = arr[2];
                        if (indexCh >= 0 && indexCh < names.Count)
                        {
                            var oldName = names[indexCh];
                            names[indexCh] = newName;
                            Console.WriteLine($"{oldName} changed his username to {newName}.");
                        }
                        break;

                }
            }
            int blacklistedNamesCount = 0;
            int lostNamesCount = 0;
            foreach (var item in names)
            {
                if (item == "Blacklisted")
                {
                    blacklistedNamesCount++;
                }
                else if(item == "Lost")
                {
                    lostNamesCount++;
                }
            }
            Console.WriteLine($"Blacklisted names: {blacklistedNamesCount} ");
            Console.WriteLine($"Lost names: {lostNamesCount}");
            Console.WriteLine(string.Join(" ", names));
        }
    }
}
