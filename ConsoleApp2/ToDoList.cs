using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class ToDoList
    {
        static void Main()
        {
            Console.WriteLine("Welcome To The To Do List Program . ");
            List<string> todoList = new List<string>();
            string option = "";

            while(option != "e")
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Enter 1 to add the item . ");
                Console.WriteLine("Enter 2 to remove the item .");
                Console.WriteLine("Enter 3 to display the item .");
                Console.WriteLine("Enter e to exit .");

                Console.WriteLine("Enter What you would like to do ? ");
                option = Console.ReadLine();

                if(option == "1")
                {
                    Console.WriteLine("Enter the item to be added : ");
                    string item = Console.ReadLine();
                    todoList.Add(item);
                }

                else if (option =="2")
                {
                    for (int i=0;i<todoList.Count;i++)
                    {
                        Console.WriteLine($"{i} " +" : "+ todoList[i]);
                    }

                    Console.WriteLine("Enter the index of the item you wished to delete . ");
                    string snum = Console.ReadLine();
                    int num = 0;
                    int.TryParse(snum,out num);
                    todoList.RemoveAt(num);

                }

                else if (option =="3")
                {
                    if (!todoList.Any())
                    {
                        Console.WriteLine("The list is Empty,Please Press 1 to add item .");
                    }
                    else
                    {
                        Console.WriteLine("The Items in the list are  ");
                        for (int i = 0; i < todoList.Count; i++)
                        {
                            Console.WriteLine(i +" : "+ todoList[i]);
                        }
                    }
                    
                }

                else if(option=="e")
                {
                    Console.WriteLine("Exiting the program . ");
                }

                else
                {
                    Console.WriteLine("Invalid Choice .");
                }
            }
            Console.WriteLine("Thank You for Using the To Do List App :)");
        }
    }
}
