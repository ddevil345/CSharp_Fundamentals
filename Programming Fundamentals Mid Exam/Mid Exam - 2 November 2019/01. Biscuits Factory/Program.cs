using System;

namespace _01._Biscuits_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int cookiesPerWorker = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int rival = int.Parse(Console.ReadLine());
            
            int total = 0;
            
            int lessDay = 0;
            for (int i = 1; i <= 30; i++)
            {
                lessDay++;
                double cookiesPerDay = cookiesPerWorker * workers;
                if (lessDay == 3)
                {
                    cookiesPerDay = Math.Ceiling(cookiesPerDay * 0.75);
                    lessDay = 0;
                }
                
                total += (int)Math.Ceiling(cookiesPerDay);
            }

            if (total > rival)
            {
                
                int diff = total - rival;
                double result = (diff / (double)rival) * 100;
                Console.WriteLine($"You have produced {total} biscuits for the past month.");
                Console.WriteLine($"You produce {result:f2} percent more biscuits.");
            }
            else
            {
                int diff = rival - total;
                double result = (diff / (double)rival) * 100;
                Console.WriteLine($"You have produced {total} biscuits for the past month.");
                Console.WriteLine($"You produce {result:f2} percent less biscuits.");
            }
        }
    }
}
