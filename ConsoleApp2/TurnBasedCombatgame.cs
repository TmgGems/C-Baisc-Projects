using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class TurnBasedCombatgame
    {
        static void Main(string[] args)
        {
            int healPoint, attack;
            healPoint =attack = 10;
            Console.WriteLine("Welcome To The Battle Field !!!");
            Console.WriteLine("::::::::::::::::");
            Console.WriteLine("Enter the Player A Points.");
            int playerApoints = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Player B Points.");
            int playerBpoints = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("------------------");
            Console.WriteLine($"Player A Points : {playerApoints}");
            Console.WriteLine($"Player B Points : {playerBpoints}");
            Random random = new Random();

            while(playerApoints > 0 && playerBpoints > 0)
            {
                int randomNum = random.Next(1, 21);
                Console.WriteLine($"RandomNumber : {randomNum}");

                if (randomNum % 2 == 0)
                {
                    Console.WriteLine("*****PLayer  A Turn*****");
                    {
                        Console.WriteLine("Enter A to Attack Enemy and H to Heal");
                        string choice = Console.ReadLine();
                        if (choice == "A")
                        {
                            playerBpoints -= attack;
                        }
                        else
                        {
                            playerApoints += healPoint;
                        }
                        Console.WriteLine($"Player A Points :{playerApoints}.");
                        Console.WriteLine($"Player B Points :{playerBpoints}.");
                    }
                }

                else
                {
                    Console.WriteLine("*****PLayer  B Turn*****");
                    {
                        Console.WriteLine("Enter A to Attack Player and H to Heal");
                        string choice = Console.ReadLine();
                        if (choice == "A")
                        {
                            playerApoints -= attack;
                        }
                        else
                        {
                            playerBpoints += healPoint;
                        }
                        Console.WriteLine($"Player A Points :{playerApoints}.");
                        Console.WriteLine($"Player B Points :{playerBpoints}.");
                    }
                }
            }

            if(playerApoints != 0)
            {
                Console.WriteLine("Player A Won the Game :) and Player B lost the Game . ");
            }
            else
            {
                Console.WriteLine("Player B Won the Game :) and Player A lost the Game . ");
            }
        }
    }
}
