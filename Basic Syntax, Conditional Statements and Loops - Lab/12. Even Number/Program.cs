using System;

namespace _12._Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int num = int.Parse(Console.ReadLine());

                if (num % 2 != 0)
                {
                    Console.WriteLine("Please write an even number.");
                }
                else
                {
                    num = Math.Abs(num);
                    Console.WriteLine($"The number is: {num}");
                    break;
                }
            }
        }
    }
}
