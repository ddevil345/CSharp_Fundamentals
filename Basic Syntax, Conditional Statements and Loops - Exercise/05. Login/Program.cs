using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string user = Console.ReadLine();
            int countBadPass = 0;
            while (true)
            {
                string pass = Console.ReadLine();
                //string verify = strrev(user);

                char[] cArray = user.ToCharArray();
                string verify = String.Empty;
                for (int i = cArray.Length - 1; i > -1; i--)
                {
                    verify += cArray[i];
                }

                if (pass != verify)
                {
                    countBadPass++;
                    if (countBadPass >= 4)
                    {
                        Console.WriteLine($"User {user} blocked!");
                        break;
                    }
                    Console.WriteLine("Incorrect password. Try again.");
                }
                else
                {
                    Console.WriteLine($"User {user} logged in.");
                    break;
                }
            }
        }
    }
}
