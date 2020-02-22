using System;
using System.Collections.Generic;
using System.Linq;


namespace _03._School_Library
{
 
    class Program
    {

        static void Main(string[] args)
        {
            
            
            List<string> books = Console.ReadLine().Split('&').ToList();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Done")
                {
                    break;
                }

                var arr = input.Split(" | ").ToList();

                switch (arr[0])
                {
                    case "Add Book":
                        
                        string nameAdd = arr[1];
                        int resultAdd = books.FindIndex(element => element == nameAdd);
                        if (resultAdd == -1)
                        {
                            books.Insert(0, nameAdd);
                        }
                        break;
                        
                    case "Take Book":
                        string nameTake = arr[1];
                        int resultTake = books.FindIndex(element => element == nameTake);
                        if (resultTake != -1)
                        {
                            books.RemoveAt(resultTake);
                        }
                        
                        break;

                    case "Swap Books":
                        string bookOne = arr[1];
                        string bookTwo = arr[2];
                        int resultOne = books.FindIndex(element => element == bookOne);
                        int resultTwo = books.FindIndex(element => element == bookTwo);
                        if (resultOne != -1 && resultTwo != -1)
                        {
                            books[resultOne] = bookTwo;
                            books[resultTwo] = bookOne; 
                        }
                        
                        break;

                    case "Insert Book":
                        string insBook = arr[1];
                        books.Add(insBook);
                        break;

                    case "Check Book":
                        int checkBook = int.Parse(arr[1]);
                        if (checkBook > -1 && checkBook < books.Count)
                        {
                            Console.WriteLine(books[checkBook]);
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", books));
        }


    }

}
