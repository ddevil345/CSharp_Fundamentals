using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Weaponsmith
{
    class Program
    {
        static void Main(string[] args)
        {
            var weapons = Console.ReadLine().Split("|").ToList();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Done")
                {
                    break;
                }
                var arr = input.Split().ToList();

                switch (arr[0])
                {
                    case "Move":
                        if (arr[1] == "Left")
                        {
                            int index1 = int.Parse(arr[2]);
                            if (index1 >= 1 && index1 < weapons.Count)
                            {
                                int index2 = index1 - 1;
                                string leftItem = weapons[index2];
                                string rirghtItem = weapons[index1];
                                
                                weapons.RemoveAt(index1);
                                weapons.RemoveAt(index2);
                                
                                weapons.Insert(index2, rirghtItem);
                                weapons.Insert(index1, leftItem);
                                
                                
                            }
                        }
                        else if (arr[1] == "Right")
                        {
                            int index1 = int.Parse(arr[2]);
                            if (index1 >= 0 && index1 < weapons.Count -2)
                            {
                                int index2 = index1 + 1;
                                string leftItem = weapons[index2];
                                string rirghtItem = weapons[index1];
                                weapons.RemoveAt(index2);
                                weapons.RemoveAt(index1);
                                weapons.Insert(index1, leftItem);
                                weapons.Insert(index2, rirghtItem);
                                
                            }

                        }
                        break;
                    case "Check":
                        if (arr[1] == "Even")
                        {
                            List<string> evenList = new List<string>();
                            for (int i = 0; i < weapons.Count; i++)
                            {
                                if (i % 2 == 0)
                                {
                                    evenList.Add(weapons[i]);
                                    
                                }
                            }
                            Console.WriteLine(string.Join(" ",evenList));
                        }
                        else if (arr[1] == "Odd")
                        {
                            List<string> oddList = new List<string>();
                            for (int i = 0; i < weapons.Count; i++)
                            {
                                if (i % 2 != 0)
                                {
                                    oddList.Add(weapons[i]);

                                }

                            }
                            Console.WriteLine(string.Join(" ", oddList));
                        }
                        
                        break;
                }
            }
            
            Console.WriteLine($"You crafted {string.Join("",weapons)}!");
        }
    }
}
