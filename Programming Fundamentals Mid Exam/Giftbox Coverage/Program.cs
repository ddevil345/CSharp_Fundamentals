using System;

namespace Giftbox_Coverage
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            int listsPaper = int.Parse(Console.ReadLine());
            double areaList = double.Parse(Console.ReadLine());


            double area = side * side * 6;

            int currentList = 0;
            int lessList = 0;
            double totalCover = 0;

            for (int i = 0; i < listsPaper; i++)
            {

                currentList++;
                lessList++;
                double less = 0;
                if (lessList == 3)
                {
                    less = areaList * 0.75;
                    lessList = 0;
                }
                totalCover += areaList - less;

            }

            double percent = totalCover * 100 / area;

            Console.WriteLine($"You can cover {percent:f2}% of the box.");

        }
    }

}