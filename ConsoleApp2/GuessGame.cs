using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class GuessGame
    {
        static void Main(string[] args)
        {
            //bool isGuess = false;
            Console.WriteLine("        Welcome to the Guessing Game     ");
            Console.WriteLine("...................................");

            Random random = new Random();
            int randomNum = random.Next(1, 20);
            int i = 0;
        
            while(i < 5)
            {

                Console.WriteLine("Enter your guessed number.");
                int num1 = Convert.ToInt32(Console.ReadLine());
                if(num1 > randomNum)
                {
                    Console.WriteLine("Too High.");
                }
                else if (randomNum > num1)
                {
                    Console.WriteLine("Too Low");
                }
                else
                {
                    Console.WriteLine("B.I.N.G.O You Won the Game !!!");
                    break;
                }
                i++;

                if(i == 5) 
                {
                    Console.WriteLine("Sorry You Lost the Game");
                }
            }

            Console.WriteLine("Thanks for your Love and Support :)");
        }
    }
}
