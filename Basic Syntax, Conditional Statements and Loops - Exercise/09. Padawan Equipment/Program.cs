using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double sabresPrice = double.Parse(Console.ReadLine());
            double priceRobe = double.Parse(Console.ReadLine());
            double priceBelt = double.Parse(Console.ReadLine());
            int freebelt = 0;
            double addtenpercent = Math.Ceiling(1.10 * students);
            if (students >= 6)
            {
                freebelt = (int)(students / 6);
            }
            double totalPriceBelt = priceBelt * (students - freebelt);
            double totalPriceSabresPrice = addtenpercent * sabresPrice;
            double totalPriceRobe = students * priceRobe;
            double totalPrice = totalPriceSabresPrice + totalPriceBelt + totalPriceRobe;
            if (money >= totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                totalPrice -= money;
                Console.WriteLine($"Ivan Cho will need {totalPrice:f2}lv more.");
            }
        }
    }
}
