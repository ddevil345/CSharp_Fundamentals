using System;
using System.Collections.Generic;
using System.Linq;
namespace _03._Tanks_Collector
{
    class Program
    {
        static void Main(string[] args)
        {
            var tanks = Console.ReadLine().Split(", ").ToList();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var arr = Console.ReadLine().Split(", ").ToList();

                switch (arr[0])
                {
                    case "Add":
                        var tankName = arr[1];
                        int idx = tanks.FindIndex(x => x == tankName);
                        
                        if (idx == -1)
                        {
                            tanks.Add(tankName);
                            Console.WriteLine($"Tank successfully bought");
                        }
                        else
                        {
                            Console.WriteLine($"Tank is already bought");
                        }
                        break;
                    case "Remove":
                        var tankNameRemove = arr[1];
                        int idxRemove = tanks.FindIndex(x => x == tankNameRemove);
                        if (idxRemove != -1)
                        {
                            tanks.RemoveAt(idxRemove);
                            Console.WriteLine($"Tank successfully sold");
                        }
                        else
                        {
                            Console.WriteLine($"Tank not found");
                        }
                        break;
                    case "Remove At":
                        int remIdex = int.Parse(arr[1]);
                        if (remIdex >= 0 && remIdex < tanks.Count)
                        {
                            tanks.RemoveAt(remIdex);
                            Console.WriteLine("Tank successfully sold");
                        }
                        else
                        {
                            Console.WriteLine("Index out of range");
                        }
                        break;
                    case "Insert":
                        int intIdx = int.Parse(arr[1]);
                        var intName = arr[2];
                        if (intIdx > 0 && intIdx < tanks.Count)
                        {
                            int sIdx = tanks.FindIndex(x => x == intName);
                            if (sIdx == -1)
                            {
                                tanks.Insert(intIdx, intName);
                                Console.WriteLine("Tank successfully bought");
                            }
                            else
                            {
                                Console.WriteLine("Tank is already bought");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Index out of range");
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", tanks));
        }
    }
}
