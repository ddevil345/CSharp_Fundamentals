using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split(", ").ToList();

      

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Craft!")
                {
                    break;
                }

                var arr = input.Split(" - ").ToList();

                switch (arr[0])
                {
                    case "Collect":
                        var item = arr[1];
                        if (!items.Contains(item))
                        {
                            items.Add(item);
                        }
                        break;
                    case "Drop":
                        var itemDrop = arr[1];
                        if (items.Contains(itemDrop))
                        {
                            items.Remove(itemDrop);
                        }
                        break;
                    case "Combine Items":
                        var split = arr[1].Split(':').ToList();
                        var oldItem = split[0];
                        var newItem = split[1];
                        if (items.Contains(oldItem))
                        {
                            int idxOld = items.FindIndex(x => x == oldItem);
                            int idxNew = idxOld + 1;
                            items.Insert(idxNew, newItem);
                        }
                        break;
                    case "Renew":
                        var reItem = arr[1];
                        if (items.Contains(reItem))
                        {
                            int idxRe = items.FindIndex(x => x == reItem);
                            var temp = items[idxRe];
                            items.RemoveAt(idxRe);
                            items.Add(reItem);
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(", ",items));
        }
    }
}
