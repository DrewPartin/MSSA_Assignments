using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._2
{
    class Program
    {
        private int num1;
        private int num2;
        
        private void AddNumbers()
        {
            Console.WriteLine("Please enter the 1st Number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the 2nd Number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            int sum = num1 + num2;
            Console.WriteLine($"The sum of {num1} and {num2} is: {sum}");
        }
        private void SubtractNumbers()
        {
            Console.WriteLine("Please enter the 1st Number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the 2nd Number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            int difference = num1 - num2;
            Console.WriteLine($"The difference of {num1} and {num2} is: {difference}");
        }

        private void MultiplyNumbers()
        {
            Console.WriteLine("Please enter the 1st Number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the 2nd Number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            int product = num1 * num2;
            Console.WriteLine($"The product of {num1} and {num2} is: {product}");
        }

        private void DivideNumbers()
        {
            Console.WriteLine("Please enter the 1st Number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the 2nd Number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num2 == 0)
            {
                Console.WriteLine("Undefined! The denominator cannot be equal to zero.");
            }
            else
            {
                int quotient = num1 / num2;
                Console.WriteLine($"The difference of {num1} and {num2} is: {quotient}");
            }
        }

        private void EqualNumbers()
        {
            Console.WriteLine("Enter the 1st number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 2nd number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 == num2)
            {
                Console.WriteLine($"{num1} and {num2} are equal!");
            }
            else
            {
                Console.WriteLine($"{num1} and {num2} are not equal.");
            }
        }

        private void NaturalNumberAddition()
        {
            int i, sum = 0;
            for (i = 1; i <= 10; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine($"The sum of these numbers is {sum}.");
            
        }

        static void Main(string[] args)
        {
        start:
            Console.WriteLine("Please select from the following options:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Equivalence");
            Console.WriteLine("6. See the sum of the first 10 natural numbers");
            int selection = Convert.ToInt32(Console.ReadLine());
            switch (selection)
            {
                case 1:
                    {
                        Console.WriteLine("Let's add two numbers!");
                        Program p1 = new Program();
                        p1.AddNumbers();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Let's subtract two numbers!");
                        Program p2 = new Program();
                        p2.SubtractNumbers();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Let's multiply two numbers!");
                        Program p3 = new Program();
                        p3.MultiplyNumbers();
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Let's divide two numbers!");
                        Program p4 = new Program();
                        p4.DivideNumbers();
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Let's see if two numbers are equal or not!");
                        Program p5 = new Program();
                        p5.EqualNumbers();
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Let'e see the first 10 natural numbers and add them together!");
                        Console.WriteLine("Press Enter to continue...");
                        Console.ReadLine();
                        Console.WriteLine("The first 10 natural numbers are 1, 2, 3, 4, 5, 6, 7, 8, 9, and 10");
                        Program p6 = new Program();
                        p6.NaturalNumberAddition();
                        break;
                    }

                default:
                    {
                        Console.WriteLine($"{selection} is not a valid selection. Please try again.");
                        goto start;
                    }
            }
            Console.WriteLine("Would you like to solve another problem? y/n?:");
            if (Convert.ToChar(Console.ReadLine().ToLower()) == 'y')
            {
                goto start;
            }
            else
            {
                Console.WriteLine("Thank you for using this application! Goodbye.");
            }
        }
    }
}
