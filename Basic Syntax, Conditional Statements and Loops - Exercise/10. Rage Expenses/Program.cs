using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostgames = int.Parse(Console.ReadLine());
            double priceHeadset = double.Parse(Console.ReadLine());
            double priceMouse = double.Parse(Console.ReadLine());
            double priceKeyboard = double.Parse(Console.ReadLine());
            double priceDisplay = double.Parse(Console.ReadLine());
            double lostHeadset = (int)(lostgames / 2);
            double lostMouse = (int)(lostgames / 3);
            double lostKeyboard = (int)(lostgames / 6);
            double lostDisplay = (int)(lostgames / 12);
            double price = (priceHeadset * lostHeadset) + (priceMouse * lostMouse) + (priceKeyboard * lostKeyboard) + (priceDisplay * lostDisplay);
            Console.WriteLine($"Rage expenses: {price:f2} lv.");
        }
    }
}
