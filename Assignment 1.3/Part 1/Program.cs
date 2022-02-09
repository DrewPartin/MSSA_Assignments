using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._3
{
    class Program
    {
        private void TriangleArea()
        {
            Console.WriteLine("Enter the base of the triangle in inches: ");
            int b = Convert.ToInt32(Console.ReadLine());           
            Console.WriteLine("Enter the height of the triangle in inches: ");
            int h = Convert.ToInt32(Console.ReadLine());
            double tArea = ((0.5) * (b * h));
            Console.WriteLine($"The area of a triangle with a base of {b} inches and a height of {h} inches is {tArea} square inches.");
        }

        private void SquareArea()
        {
            int s;
            Console.WriteLine("Enter the length of one side of the square in inches: ");
            s = Convert.ToInt32(Console.ReadLine());
            int sArea = (s * s);
            Console.WriteLine($"The area of a square with a side length of {s} inches is {sArea} square inches.");
        }

        private void RectangleArea()
        {
            Console.WriteLine("Enter the length of the rectangle in inches: ");
            int l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the width of the rectangle in inches: ");
            int w = Convert.ToInt32(Console.ReadLine());
            int rArea = (l * w);
            Console.WriteLine($"The area of a rectangle with a length of {l} inches and a width of {w} inches is {rArea} square inches.");
        }

        static void Main(string[] args)
        {
            start:
            Console.WriteLine("This program will calculate the area of various shapes.");
            Console.WriteLine("Choose the number next to a shape below to get started.");
            Console.WriteLine("1. Triangle");
            Console.WriteLine("2. Square");
            Console.WriteLine("3. Rectangle");
            int choice = Convert.ToInt32(Console.ReadLine()); 
            switch (choice)
            {
                case 1:
                    {
                        Program t1 = new Program();
                        t1.TriangleArea();
                        break;
                    }
                case 2:
                    {
                        Program s1 = new Program();
                        s1.SquareArea();
                        break;
                    }
                case 3:
                    {
                        Program r1 = new Program();
                        r1.RectangleArea();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("That is not a valid selection. Please choose from one of the following options: ");
                        goto start;
                    }
            }
            Console.WriteLine("Would you like to calculate another shape? y/n: ");
            if (Convert.ToChar(Console.ReadLine().ToLower()) == 'y')
            {
                goto start;
            }
            else
            {
                Console.WriteLine("Thank you for using this application! Goodbye.");
                Console.ReadLine();
            }
        }
    }
}
