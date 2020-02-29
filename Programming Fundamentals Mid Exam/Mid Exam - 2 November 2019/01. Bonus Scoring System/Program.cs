using System;

namespace _01._Bonus_Scoring_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            int lectures = int.Parse(Console.ReadLine());
            int additionalBonus = int.Parse(Console.ReadLine());

            double maxBonusPoints = 0;
            int studentAttendancesSave = 0;
            for (int i = 0; i < students; i++)
            {
                //{total bonus} = {student attendances} / {course lectures} * (5 + {additional bonus})
                double studentAttendances = int.Parse(Console.ReadLine());
                double totalBonus = studentAttendances / lectures * (5 + additionalBonus);

                int tb = (int)Math.Ceiling(totalBonus);
                //Console.WriteLine($"studen: {i+1} - d: {totalBonus} tb:{tb}");
                if (totalBonus > maxBonusPoints)
                {
                    maxBonusPoints = totalBonus;
                    studentAttendancesSave = (int)studentAttendances;
                }

            }
            int res = (int)Math.Ceiling(maxBonusPoints);
            Console.WriteLine($"Max Bonus: {res}.");
            Console.WriteLine($"The student has attended {studentAttendancesSave} lectures.");

        }
    }
}