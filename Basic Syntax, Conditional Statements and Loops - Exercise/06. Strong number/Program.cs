using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int s1 = 0;
            int fact;
            int n1 = n;

            for (int j = n; j > 0; j = j / 10)
            {

                fact = 1;
                for (int i = 1; i <= j % 10; i++)
                {
                    fact = fact * i;
                }
                s1 = s1 + fact;

            }

            if (s1 == n1)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
