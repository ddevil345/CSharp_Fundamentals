using System;

namespace _01._Experience_Gaining
{
    class Program
    {
        static void Main(string[] args)
        {
            double needExp = double.Parse(Console.ReadLine());
            int battleCount = int.Parse(Console.ReadLine());
            double expEarnedperBattle = 0;
            double currentExp = 0;
            int countMore = 0;
            int countLess = 0;
            int currentBattle = 0;
            bool isReady = false;
            for (int i = 0; i < battleCount; i++)
            {
                expEarnedperBattle = double.Parse(Console.ReadLine());
                countMore++;
                countLess++;
                currentBattle++;

                if (countMore == 3)
                {
                    expEarnedperBattle *= 1.15;
                    countMore = 0;
                }
                if (countLess == 5)
                {
                    expEarnedperBattle *= 0.90;
                    countLess = 0;
                }

                currentExp += expEarnedperBattle;
                

                if (currentExp >= needExp)
                {
                    isReady = true;
                    break;
                }
            }

            if (isReady == true)
            {
                Console.WriteLine($"Player successfully collected his needed experience for {currentBattle} battles.");
            }
            else
            {
                needExp -= currentExp;
                Console.WriteLine($"Player was not able to collect the needed experience, {needExp:f2} more needed.");
            }
    }
}
