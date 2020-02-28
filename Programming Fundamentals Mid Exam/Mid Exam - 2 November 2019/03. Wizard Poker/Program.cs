using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Wizard_Poker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> arsenal = Console.ReadLine().Split(':').ToList();
            var deck = new List<string>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Ready")
                {
                    break;
                }

                var arr = input.Split().ToList();

                switch (arr[0])
                {
                    case "Add":
                        var addName = arr[1];
                        
                        if (!arsenal.Contains(addName))
                        {
                            Console.WriteLine("Card not found.");
                        }
                        else
                        {
                            deck.Add(addName);
                        }
                        break;
                    case "Insert":
                        int insIndex = int.Parse(arr[2]);
                        var insName = arr[1];
                        if (arsenal.Contains(insName) && insIndex >= 0 && insIndex < deck.Count)
                        {
                            deck.Insert(insIndex, insName); 
                        }
                        else
                        {
                            Console.WriteLine("Error!");
                        }
                        break;
                    case "Remove":
                        var remName = arr[1];
                        if (deck.Contains(remName))
                        {
                            deck.Remove(remName);
                        }
                        else 
                        {
                            Console.WriteLine("Card not found.");
                        }
                        break;
                    case "Swap":
                        var nameOne = arr[1];
                        var nameTwo = arr[2];

                        SwapElements(deck, nameOne, nameTwo);

                        break;

                    case "Shuffle":
                        deck.Reverse();
                        break;
                }
            }
            Console.WriteLine(string.Join(" ",deck));
        }

        private static void SwapElements(List<string> list, string elementOne, string elementTwo)
        {
            int resultOne = list.FindIndex(element => element == elementOne);
            int resultTwo = list.FindIndex(element => element == elementTwo);
            if (resultOne != -1 && resultTwo != -1)
            {
                list[resultOne] = elementTwo;
                list[resultTwo] = elementOne;
            }
        }
    }
}
