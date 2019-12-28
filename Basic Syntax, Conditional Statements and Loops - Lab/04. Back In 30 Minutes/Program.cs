using System;

namespace _04._Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int mins = int.Parse(Console.ReadLine());

            int totalMins = mins + 30;

            if (totalMins > 59)
            {
                hours++;
                mins = totalMins - 60;
            }
            else
            {
                mins = totalMins;
            }
            if (hours > 23)
            {
                hours = 0;

            }

            Console.WriteLine($"{hours}:{mins:d2}");
        }
    }
}
