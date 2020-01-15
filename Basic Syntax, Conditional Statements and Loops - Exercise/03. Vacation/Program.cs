using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            decimal totalPrice = 0;

            switch (day)
            {
                case "Friday":
                    if (type == "Students")
                    {
                        totalPrice = people * 8.45m;
                        if (people >= 30)
                        {
                            totalPrice *= 0.85m;
                        }
                    }
                    else if (type == "Business")
                    {
                        totalPrice = people * 10.90m;
                        if (people >= 100)
                        {
                            totalPrice = (people - 10) * 10.90m;
                        }
                    }
                    else if (type == "Regular")
                    {
                        totalPrice = people * 15;
                        if (people >= 10 && people <= 20)
                        {
                            totalPrice *= 0.95m;
                        }
                    }
                    Console.WriteLine($"Total price: {totalPrice:f2}");
                    break;
                case "Saturday":
                    if (type == "Students")
                    {
                        totalPrice = people * 9.80m;
                        if (people >= 30)
                        {
                            totalPrice *= 0.85m;
                        }
                    }
                    else if (type == "Business")
                    {
                        totalPrice = people * 15.60m;
                        if (people >= 100)
                        {
                            totalPrice = (people - 10) * 15.60m;
                        }
                    }
                    else if (type == "Regular")
                    {
                        totalPrice = people * 20;
                        if (people >= 10 && people <= 20)
                        {
                            totalPrice *= 0.95m;
                        }
                    }
                    Console.WriteLine($"Total price: {totalPrice:f2}");
                    break;
                case "Sunday":
                    if (type == "Students")
                    {
                        totalPrice = people * 10.46m;
                        if (people >= 30)
                        {
                            totalPrice *= 0.85m;
                        }
                    }
                    else if (type == "Business")
                    {
                        totalPrice = people * 16;
                        if (people >= 100)
                        {
                            totalPrice = (people - 10) * 16;
                        }
                    }
                    else if (type == "Regular")
                    {
                        totalPrice = people * 22.50m;
                        if (people >= 10 && people <= 20)
                        {
                            totalPrice *= 0.95m;
                        }
                    }
                    Console.WriteLine($"Total price: {totalPrice:f2}");
                    break;
            }
        }
    }
}
