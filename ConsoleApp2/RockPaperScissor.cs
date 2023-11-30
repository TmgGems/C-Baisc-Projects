using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class RockPaperScissor
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int playerPoints = 0,enemyPoints = 0;
            Console.WriteLine("Welcome To The Rock Paper Scissor Game Station !!!");
            Console.WriteLine("...............:)");

            while (playerPoints != 3 && enemyPoints != 3)
            {
                int randomNum = random.Next(1, 4);
                Console.WriteLine("Choose 'r' for Rock, 'p' for Paper and 's' for Scissor .");
                string playerChoice = Console.ReadLine();


                if (randomNum == 1)
                {
                    Console.WriteLine("Enemy Choose Rock");
                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Tie");
                            break;
                        case "p":
                            Console.WriteLine("Player Won this round .");
                            playerPoints++;
                            break;
                        default:
                            Console.WriteLine("Enemy won this round .");
                            enemyPoints++;
                            break;
                    }
                    Console.WriteLine($"playerPoints :{playerPoints}");
                    Console.WriteLine($"enemyPoints :{enemyPoints}");
                }
                else if (randomNum == 2)
                {
                    Console.WriteLine("Enemy Choose Paper .");
                    switch (playerChoice)
                    {
                        case "p":
                            Console.WriteLine("Tie");
                            break;
                        case "r":
                            Console.WriteLine("Player Won this round .");
                            playerPoints++;
                            break;
                        default:
                            Console.WriteLine("Enemy won this round .");
                            enemyPoints++;
                            break;
                    }
                    Console.WriteLine($"playerPoints :{playerPoints}");
                    Console.WriteLine($"enemyPoints :{enemyPoints}");
                }
                else
                {
                    Console.WriteLine("Enemy Choose Scissor .");
                    switch (playerChoice)
                    {
                        case "s":
                            Console.WriteLine("Tie");
                            break;
                        case "r":
                            Console.WriteLine("Player Won this round .");
                            playerPoints++;
                            break;
                        default:
                            Console.WriteLine("Enemy won this round .");
                            enemyPoints++;
                            break;
                    }
                    Console.WriteLine($"playerPoints :{playerPoints}");
                    Console.WriteLine($"enemyPoints :{enemyPoints}");
                }

                if (playerPoints == 3)
                {
                    Console.WriteLine("PLayer Won The Game !");
                }
                else if (playerPoints == 3)
                {
                    Console.WriteLine("Enemy Lose The Game !");
                }
                else
                    continue;
            }

        }
    }
}
