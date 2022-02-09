using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Point P1 = new Point();
            Point P2 = new Point();

            Console.WriteLine("This program will determine the relation of two points on a graph.");

        start:
            Console.Write("Please enter an x coordinate for the first point: ");
            P1.x_coordinate = Int32.Parse(Console.ReadLine());
            Console.Write("Please enter a y coordinate for the first point: ");
            P1.y_coordinate = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Your first point is at location ({P1.x_coordinate},{P1.y_coordinate}).");
            Console.WriteLine("");

            Console.Write("Please enter an x coordinate for the second point: ");
            P2.x_coordinate = Int32.Parse(Console.ReadLine());
            Console.Write("Please enter a y coordinate for the second point: ");
            P2.y_coordinate = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Your second point is at location ({P2.x_coordinate},{P2.y_coordinate}).");
            Console.WriteLine("");

            if (P1.x_coordinate < P2.x_coordinate)
            {
                Console.WriteLine("Point 2 is to the right of Point 1.");
            }
            else if (P1.x_coordinate > P2.x_coordinate)
            {
                Console.WriteLine("Point 2 is to the left of Point 1.");
            }
            else
            {
                Console.WriteLine("Point 1 and Point 2 are on the same axis.");
            }
            Console.WriteLine("");
            Console.WriteLine("Would you like to compare another set of points?");
            if (Convert.ToChar(Console.ReadLine().ToLower()) == 'y')
            {
                goto start;
            }
            else
            {
                Console.WriteLine("Thank you for using this application! Press Enter to close. Goodbye.");
                Console.ReadLine();

            }
        }
    }
}
