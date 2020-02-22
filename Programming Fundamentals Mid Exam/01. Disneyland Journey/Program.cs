using System;

namespace _01._Disneyland_Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double needMoney = int.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double saved = 0;
            int currentMonth = 0;
            int bonusMonth = 0;
            for (int i = 1; i <= months; i++)
            {
                currentMonth++;
                bonusMonth++;
                
                if (bonusMonth == 4)
                {
                    saved += saved * 0.25;
                    bonusMonth = 0;
                }
                                

                if (currentMonth > 1 && currentMonth % 2 != 0)
                {
                    saved -= saved * 0.16;
                }
                saved += needMoney * 0.25;
                
            }

            if (saved > needMoney)
            {
                saved -= needMoney;
                Console.WriteLine($"Bravo! You can go to Disneyland and you will have {saved:f2}lv. for souvenirs.");
            }
            else
            {
                needMoney -= saved;
                Console.WriteLine($"Sorry. You need {needMoney:f2}lv. more.");
            }
            
        }
    }
}
