using System;

namespace Prov
{
    class Program
    {
        static void Main(string[] args)
        {
            string coordinates = Console.ReadLine();
            Console.WriteLine("Welcome to another episode of Bomb That Ship!");
            Console.ReadLine();
            Console.WriteLine("Your goal as the player is to try to hit the enemy Ship. Its coordinates is between 1,0 and 10,0 on your coordinated.");
            Console.ReadLine();
            Console.WriteLine("So basically you have to guess which coordinates it is on, between the number 1 and 10");
            Console.ReadLine();
            Console.WriteLine("So lets get started!");
            Console.ReadLine();


            //Miss
            if (coordinates != "7")
            {
                Console.WriteLine("Darn it!");

            }
            //Near Miss!
            if (coordinates == "6")
            {
                Console.WriteLine("Near Miss!");
            }
            Console.ReadLine();
            if (coordinates == "8")
            {
                Console.WriteLine("Near Miss!");
            }
            //Miss!
            if (coordinates == "5")
            {
                Console.WriteLine("Miss!");
            }
            Console.ReadLine();
            if (coordinates == "9")
            {
                Console.WriteLine("Miss!");
            }
            Console.ReadLine();
            //By a lot!
            if (coordinates == "4")
            {
                Console.WriteLine("Miss!");
            }
            Console.ReadLine();
            if (coordinates == "3")
            {
                Console.WriteLine("Miss!");
            }
            Console.ReadLine();
            //Holy shit you hit a ship of innocent civilians!
            if (coordinates == "2")
            {
                Console.WriteLine("Holy shit you hit a ship of innocent civilians!");
            }
            Console.ReadLine();
            if (coordinates == "1")
            {
                Console.WriteLine("Damn, you're pretty bad at this...");
            }
            Console.ReadLine();
            //HIT!!!
            if (coordinates == "7")
            {
                Console.WriteLine("CLEAN HIT!!! ENEMY SHIP DOWN!");
            }
            Console.ReadLine();






        }
    }
}
