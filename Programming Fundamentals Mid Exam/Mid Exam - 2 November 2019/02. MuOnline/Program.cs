using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> rooms = Console.ReadLine().Split('|').ToList();
            int hp = 100;
            int bitcoins = 0;
            int room = 1;
            bool isDead = false;

            for (int i = 0; i < rooms.Count; i++)
            {
                if (isDead)
                {
                    break;
                }
                
                var arr = rooms[i].Split().ToList();

                string command = arr[0];
                
                switch (command)
                {
                    case "potion":
                        int heal = int.Parse(arr[1]);
                        int diff = 100 - hp;
               
                        
                            if (hp + heal > 100)
                            {
                                heal = diff;
                            }
                        hp += heal;
                        Console.WriteLine($"You healed for {heal} hp.");
                        Console.WriteLine($"Current health: {hp} hp.");
                        
                        break;
                    case "chest":
                        int addbc = int.Parse(arr[1]);
                        bitcoins += addbc;
                        Console.WriteLine($"You found {addbc} bitcoins.");
                        break;
                    default:
                        var monster = arr[0];
                        int attack = int.Parse(arr[1]);
                        hp -= attack;
                        if ( hp <= 0)
                        {
                            Console.WriteLine($"You died! Killed by {monster}.");
                            Console.WriteLine($"Best room: {room}");
                            isDead = true;
                            break;
                        }
                        else
                        {
                        
                            Console.WriteLine($"You slayed {monster}.");
                        }
                        break;

                }

                room++;
            }
            if (!isDead)
            {
                Console.WriteLine($"You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {hp}");
            }
        }
    }
}
