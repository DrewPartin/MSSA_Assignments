using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4._2
{
    class Circle
    {
        public double radius { get; set; }
        public double area { get; set; }
        public double CalculateArea()
        {
            this.area = Math.PI * this.radius * this.radius;
            return this.area;
        }
        public static Circle operator +(Circle c1, Circle c2)
        {
            Circle cnew = new Circle();
            cnew.area = c1.area + c2.area;
            return cnew;
        }
        public static Circle operator -(Circle c1, Circle c2)
        {
            Circle cNew = new Circle();
            if (c1.radius > c2.radius)
            {
                cNew.area = c1.area - c2.area;
            }
            else
            {
                cNew.area = c2.area - c1.area;
            }
            return cNew;
        }
    }

    class Program
    {
        #region METHODS
        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Add(int a, int b, int c)
        {
            return (a + b) + c;
        }

        static float Multiply(float a, float b)
        {
            return a * b;
        }

        static float Multiply(float a, float b, float c)
        {
            return (a * b) * c;
        } 
        #endregion

        static void Main(string[] args)
        {
            #region PART 1

            char[,] array2D = new char[4, 3];
            Console.WriteLine("Enter the 12 elements in the array:");
            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    Console.Write($"Element [{i}],[{j}]: ");
                    array2D[i, j] = Char.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Your 2D array looks like this:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    Console.Write("[{0}]", array2D[i, j]);
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadLine();
            #endregion


            #region PART 2

            int[,] arrayTwoD1 = new int[3, 3];
            Console.WriteLine("Enter the 9 elements of the first matrix:");
            for (int i = 0; i < arrayTwoD1.GetLength(0); i++)
            {
                for (int j = 0; j < arrayTwoD1.GetLength(1); j++)
                {
                    Console.Write($"Element [{i}],[{j}]: ");
                    arrayTwoD1[i, j] = Int32.Parse(Console.ReadLine());
                }
            }

            int[,] arrayTwoD2 = new int[3, 3];
            Console.WriteLine("Enter the 9 elements of the second matrix:");
            for (int i = 0; i < arrayTwoD2.GetLength(0); i++)
            {
                for (int j = 0; j < arrayTwoD2.GetLength(1); j++)
                {
                    Console.Write($"Element [{i}],[{j}]: ");
                    arrayTwoD2[i, j] = Int32.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("The first matrix looks like this:");
            for (int i = 0; i < arrayTwoD1.GetLength(0); i++)
            {
                for (int j = 0; j < arrayTwoD1.GetLength(1); j++)
                {
                    Console.Write("[{0}]", arrayTwoD1[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("The second matrix looks like this:");
            for (int i = 0; i < arrayTwoD2.GetLength(0); i++)
            {
                for (int j = 0; j < arrayTwoD2.GetLength(1); j++)
                {
                    Console.Write("[{0}]", arrayTwoD2[i, j]);
                }
                Console.WriteLine();
            }

            int[,] arrayTwoD3 = new int[3, 3];
            Console.WriteLine("The combined arrays equal:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < arrayTwoD3.GetLength(0); i++)
            {
                for (int j = 0; j < arrayTwoD3.GetLength(1); j++)
                {
                    arrayTwoD3[i, j] = arrayTwoD1[i, j] + arrayTwoD2[i, j];
                    Console.Write("[{0}]", arrayTwoD3[i, j]);
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadLine();
        #endregion


            #region PART 3
        start:
            Console.WriteLine("Choose from the menu options below:");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Multiply");
            Console.WriteLine("3. Exit Application");
            int choice = Int32.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                    add:
                        Console.WriteLine("Would you like to add 2 or 3 numbers?");
                        int selection = Int32.Parse(Console.ReadLine());
                        if (selection == 2)
                        {
                            Console.Write("Enter your first number: ");
                            int A = Int32.Parse(Console.ReadLine());
                            Console.Write("Enter your second number: ");
                            int B = Int32.Parse(Console.ReadLine());
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"The sum of your two numbers is: {Add(A, B)}.");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("Press Enter to return to the main menu...");
                            Console.ReadLine();
                            goto start;
                        }
                        else if (selection == 3)
                        {
                            Console.Write("Enter your first number: ");
                            int A = Int32.Parse(Console.ReadLine());
                            Console.Write("Enter your second number: ");
                            int B = Int32.Parse(Console.ReadLine());
                            Console.Write("Enter your third number: ");
                            int C = Int32.Parse(Console.ReadLine());
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"The sum of your three numbers is: {Add(A, B, C)}.");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("Press Enter to return to the main menu...");
                            Console.ReadLine();
                            goto start;
                        }
                        else
                        {
                            Console.WriteLine("Invalid selection. Please try again.");
                            goto add;
                        }
                    }
                case 2:
                    {
                    multiply:
                        Console.WriteLine("Would you like to multiply 2 or 3 numbers?");
                        int selection2 = Int32.Parse(Console.ReadLine());
                        if (selection2 == 2)
                        {
                            Console.Write("Enter your first number: ");
                            int A = Int32.Parse(Console.ReadLine());
                            Console.Write("Enter your second number: ");
                            int B = Int32.Parse(Console.ReadLine());
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"The product of your two numbers is: {Multiply(A, B)}.");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("Press Enter to return to the main menu...");
                            Console.ReadLine();
                            goto start;
                        }
                        else if (selection2 == 3)
                        {
                            Console.Write("Enter your first number: ");
                            int A = Int32.Parse(Console.ReadLine());
                            Console.Write("Enter your second number: ");
                            int B = Int32.Parse(Console.ReadLine());
                            Console.Write("Enter your third number: ");
                            int C = Int32.Parse(Console.ReadLine());
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"The product of your three numbers is: {Multiply(A, B, C)}.");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("Press Enter to return to the main menu...");
                            Console.ReadLine();
                            goto start;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid selection. Please try again.");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            goto multiply;
                        }
                    }
                case 3:
                    {                        
                        Console.WriteLine("Thank you for using this application. Press Enter to continue...");                        
                        Console.ReadLine();
                        break;
                    }
                default:
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid selection. Please try again.");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        goto start;
                    }
            }
            #endregion


            #region PART 4
            Circle c1 = new Circle();
            Console.WriteLine("Enter the radius for the first circle:");
            c1.radius = Double.Parse(Console.ReadLine());
            Circle c2 = new Circle();
            Console.WriteLine("Enter the radius for the second circle:");
            c2.radius = Double.Parse(Console.ReadLine());
            c1.area = c1.CalculateArea();
            c2.area = c2.CalculateArea();
            Circle c3 = c1 + c2;
            Circle c4 = c1 - c2;
            Console.WriteLine($"Area of circle 1 plus circle 2 is: {c3.area}");
            Console.WriteLine($"The difference between areas of circle 1 and circle 2 is: {c4.area}.");
            Console.ReadLine(); 
            #endregion

        }
    }
}
