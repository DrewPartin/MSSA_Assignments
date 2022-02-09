using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("This program will calculate the area of shapes.");
        start:
            Console.WriteLine("Please enter a number to choose a shape: ");
            Console.WriteLine("1. Circle");
            Console.WriteLine("2. Square");
            choice = Int32.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Circle c = new Circle();
                c.Id = 1;
                c.Name = "Circle";
                Console.WriteLine($"Enter the radius of your {c.Name}");
                c.Radius = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Please select a color from the following options:");
            tryAgain:
                Console.WriteLine("1. Red");
                Console.WriteLine("2. Pink");
                Console.WriteLine("3. Blue");
                Console.WriteLine("4. Green");
                Console.WriteLine("5. Yellow");
                int col = Int32.Parse(Console.ReadLine());
                if (col == 1)
                {
                    c.Color = "Red";
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (col == 2)
                {
                    c.Color = "Pink";
                    Console.ForegroundColor = ConsoleColor.Magenta;
                }
                else if (col == 3)
                {
                    c.Color = "Blue";
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else if (col == 4)
                {
                    c.Color = "Green";
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (col == 5)
                {
                    c.Color = "Yellow";
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid color! Please try again.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    goto tryAgain;
                }
                Console.WriteLine();
                Console.WriteLine("Your shape's information is as follows:");
                Console.WriteLine($"ID: {c.Id}");
                Console.WriteLine($"Name: {c.Name}");
                Console.WriteLine($"Color {c.Color}");
                Console.WriteLine("Area: " + c.CalculateArea());
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Press Enter to Continue...");
                Console.ReadKey();
            }
            else if (choice == 2)
            {
                Square s = new Square();
                s.Id = 1;
                s.Name = "Square";
                Console.WriteLine($"Enter a side length of your {s.Name}");
                s.SideLength = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Please select a color from the following options:");
            tryAgain2:
                Console.WriteLine("1. Red");
                Console.WriteLine("2. Pink");
                Console.WriteLine("3. Blue");
                Console.WriteLine("4. Green");
                Console.WriteLine("5. Yellow");
                int col = Int32.Parse(Console.ReadLine());
                if (col == 1)
                {
                    s.Color = "Red";
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (col == 2)
                {
                    s.Color = "Pink";
                    Console.ForegroundColor = ConsoleColor.Magenta;
                }
                else if (col == 3)
                {
                    s.Color = "Blue";
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else if (col == 4)
                {
                    s.Color = "Green";
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (col == 5)
                {
                    s.Color = "Yellow";
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid color! Please try again.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    goto tryAgain2;
                }
                Console.WriteLine();
                Console.WriteLine("Your shape's information is as follows:");
                Console.WriteLine($"ID: {s.Id}");
                Console.WriteLine($"Name: {s.Name}");
                Console.WriteLine($"Color {s.Color}");
                Console.WriteLine("Area: " + s.CalculateArea());
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Press Enter to Continue...");
                Console.ReadKey();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please choose a valid shape.");
                Console.ForegroundColor = ConsoleColor.Gray;
                goto start;
            }

            Console.WriteLine();
            Console.WriteLine("Would you like to calculate another shape? y/n");
            char redo = Char.ToLower(Convert.ToChar(Console.ReadLine()));
            if (redo == 'y')
            {
                goto start;
            }
            else if (redo == 'n')
            {
                Console.WriteLine("Thank you for using ths program. Please press enter to close...");
                Console.ReadKey();
            }
        }
    }
}