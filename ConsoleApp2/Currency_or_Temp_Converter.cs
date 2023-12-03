using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Currency_or_Temp_Converter
    {
        static void Main(string[] args)
        {
            double ausDollar, nepaliRupee;
            string choice, fahrenheit,degree_celsius,kelvin;
            Console.WriteLine("Welcome To The Currency and Temperature Converter !!! ");
            Console.WriteLine("---------------");
            Console.WriteLine("Enter c to For Currency Converter  or anything else for Temperature Converter . ");
            string answer = Console.ReadLine();

            if(answer.ToLower() == "c")
            {
                Console.WriteLine("Welcome To The Currency Converter ....");
                Console.WriteLine("Enter 1 for Nepali Rupee to Aus Dollar  or anything for Aus Dollar to Nepali Rupee .");
                int feedback =int.Parse(Console.ReadLine());
                
                if(feedback == 1)
                {
                   
                    Console.WriteLine(".........Nepali Rupee To Aus Dollar Converter......... ");
                    Console.WriteLine("Enter the Nepali amount .");
                    nepaliRupee = double.Parse(Console.ReadLine());

                    ausDollar = (nepaliRupee / 88.239667);
                    Console.WriteLine($"The ausDollar is {ausDollar} ");
                }
                else
                {
                    Console.WriteLine(".........Aus Dollar Converter To Nepali Rupee......... ");
                    Console.WriteLine("Enter the Aus Dollar amount .");
                    ausDollar = double.Parse(Console.ReadLine());

                    nepaliRupee= (ausDollar * 88.239667);
                    Console.WriteLine($"The Nepali amount is Rs {nepaliRupee} ");
                }
            }

            else
            {
                Console.WriteLine("Welcome To The Temperature COnverter . ");
                Console.WriteLine("------------------");
                Console.WriteLine("Choices ");
                Console.WriteLine("Enter 1 to convert degree cesius to fahrenheit");
                Console.WriteLine("Enter 2 to convert degree cesius to kelvin");
                Console.WriteLine("Enter 3 to convert fahrenheit to degree cesius");
                Console.WriteLine("Enter 4 to convert fahrenheit to kelvin ");
                Console.WriteLine("Enter 5 to convert kelvin to fahrenheit");
                Console.WriteLine("Enter 6 to convert kelvin to degree cesius");
                Console.WriteLine("Enter your Choice");
                choice = Console.ReadLine();

                switch(choice)
                {
                    case "1":
                        Console.WriteLine("degree cesius to fahrenheit");
                        break;

                    case "2":
                        Console.WriteLine(" degree cesius to kelvin");
                        break;

                    case "3":
                        Console.WriteLine("fahrenheit to degree cesius");
                        break;

                    case "4":
                        Console.WriteLine("fahrenheit to kelvin ");
                        break;

                    case "5":
                        Console.WriteLine("kelvin to fahrenheit");
                        break;

                    case "6":
                        Console.WriteLine(" kelvin to degree cesius");
                        break;

                    default:
                        break;
                }

            }

            Console.WriteLine("Thank you !");
        }
    }
}
