using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_Extra_Assignments
{
    class Program
    {
        #region Methods
        static int MintoSec(int minutes)
        {
            int seconds = (minutes * 60);
            return seconds;
        }

        static float TriangleArea(float t_base, float t_height)
        {
            float t_area = ((t_base * t_height) / 2);
            return t_area;
        }

        static bool GreaterOrLessThan100(int num1, int num2)
        {
            bool tf;
            int sum = num1 + num2;
            if (sum < 100)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{num1} + {num2} = {sum}.");
                Console.WriteLine("true");
                Console.ForegroundColor = ConsoleColor.Gray;
                tf = true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{num1} + {num2} = {sum}.");
                Console.WriteLine("false");
                Console.ForegroundColor = ConsoleColor.Gray;
                tf = false;
            }
            return tf;
        } 
        
        static bool IsPalindrome(string value)
        {
            int i = 0;
            int j = value.Length - 1;
            while (true)
            {
                if (i > j)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"The number {value} is a palinrome.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    return true;
                }
                char a = value[i];
                char b = value[j];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"The number {value} is not a palinrome.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    return false;
                }
                i++;
                j--;
            }
        }
        
        static string ReverseCase(string inputString)
        {
            char[] c = inputString.ToCharArray();
            char[] cUpper = inputString.ToUpper().ToCharArray();
            char[] cLower = inputString.ToLower().ToCharArray();
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == cUpper[i])
                {
                    c[i] = cLower[i];
                }
                else
                {
                    c[i] = cUpper[i];
                }
            }
            return new string(c);
        }

        static void IsEven(int number)
        {
            if ((number % 2) == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{number} is an even integer.");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{number} is an odd integer.");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }

        #endregion

        static void Main(string[] args)
        {
            try
            {
            #region Main Menu
            P_Start:
                Console.WriteLine("Choose the number from the list below to run it's associated program: ");
                Console.WriteLine("1. Minutes to Seconds");
                Console.WriteLine("2. Triangle Area");
                Console.WriteLine("3. Greater or Less Than 100");
                Console.WriteLine("4. Palindrome");
                Console.WriteLine("5. Reverse Case");
                Console.WriteLine("6. Even or Odd");
                Console.WriteLine("7. Student Grades");
                Console.WriteLine("8. Array Element Min/Max");
                Console.WriteLine("9. End Program");
                int selection = Int32.Parse(Console.ReadLine());
                switch (selection)
                {
                    case 1:
                        {
                            goto P1;
                        }
                    case 2:
                        {
                            goto P2;
                        }
                    case 3:
                        {
                            goto P3;
                        }
                    case 4:
                        {
                            goto P4;
                        }
                    case 5:
                        {
                            goto P5;
                        }
                    case 6:
                        {
                            goto P6;
                        }
                    case 7:
                        {
                            goto P7;
                        }
                    case 8:
                        {
                            goto P8;
                        }
                    case 9:
                        {
                            goto P_End;
                        }
                    default:
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid selection. Please try again.");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            goto P_Start;
                        }
                }
            #endregion

            #region P1. Minutes to Seconds
            P1:
                Console.Write("Enter a number of minutes to convert to seconds: ");
                int mins = Int32.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{mins} minutes = {(MintoSec(mins))} seconds.");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("\nWould you like to run this program again? y/n: ");
                char choiceP1 = Char.ToLower(Char.Parse(Console.ReadLine()));
                if (choiceP1 == 'y')
                {
                    goto P1;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Returning to Main Menu...");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    goto P_Start;
                }
            #endregion

            #region P2. Triangle Area
            P2:
                Console.Write("Enter the length of the base of the triangle: ");
                float b = float.Parse(Console.ReadLine());
                Console.Write("Enter the height of the triangle: ");
                float h = float.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"The area of a triangle with a base of {b} and a height of {h} is {TriangleArea(b, h)}.");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("\nWould you like to run this program again? y/n: ");
                char choiceP2 = Char.ToLower(Char.Parse(Console.ReadLine()));
                if (choiceP2 == 'y')
                {
                    goto P2;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Returning to Main Menu...");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    goto P_Start;
                }
            #endregion

            #region P3. GreaterOrLessThan100
            P3:
                Console.Write("Enter the first number: ");
                int n1 = Int32.Parse(Console.ReadLine());
                Console.Write("Enter the second number: ");
                int n2 = Int32.Parse(Console.ReadLine());
                GreaterOrLessThan100(n1, n2);
                Console.Write("\nWould you like to run this program again? y/n: ");
                char choiceP3 = Char.ToLower(Char.Parse(Console.ReadLine()));
                if (choiceP3 == 'y')
                {
                    goto P3;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Returning to Main Menu...");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    goto P_Start;
                }
            #endregion

            #region P4. Palindrome
            P4:
                Console.WriteLine("Enter a multi-digit number in order to determine if it is a palindrome:");
                string numString = Console.ReadLine();
                IsPalindrome(numString);
                Console.Write("\nWould you like to run this program again? y/n: ");
                char choiceP4 = Char.ToLower(Char.Parse(Console.ReadLine()));
                if (choiceP4 == 'y')
                {
                    goto P4;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Returning to Main Menu...");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    goto P_Start;
                }
            #endregion

            #region P5. Reverse Case
            P5:
                Console.WriteLine("Enter a string of letters or words:");
                Console.WriteLine("(Numbers and special characters can be used, but cannot have their case reversed)");
                string s = Console.ReadLine();
                string rString = ReverseCase(s);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Your string of characters with their case reversed is: {rString}.");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("\nWould you like to run this program again? y/n: ");
                char choiceP5 = Char.ToLower(Char.Parse(Console.ReadLine()));
                if (choiceP5 == 'y')
                {
                    goto P5;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Returning to Main Menu...");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    goto P_Start;
                }
            #endregion

            #region P6. Even or Odd
            P6:
                Console.Write("Enter a number: ");
                int num = Int32.Parse(Console.ReadLine());
                IsEven(num);
                Console.Write("\nWould you like to run this program again? y/n: ");
                char choiceP6 = Char.ToLower(Char.Parse(Console.ReadLine()));
                if (choiceP6 == 'y')
                {
                    goto P6;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Returning to Main Menu...");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    goto P_Start;
                }
            #endregion

            #region P7. Student Grades
            P7:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("This problem is still being solved. Please try again later.");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nPress Enter to return to the Main Menu...");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine();
                Console.ReadKey();
                goto P_Start;
            #endregion

            #region P8. Array Element Min/Max
            P8:
                Console.Write("Enter the number of elements to be stored in the array: ");
                int size = Int32.Parse(Console.ReadLine());
                int[] data = new int[size];
                for (int i = 0; i < size; i++)
                {
                    Console.Write($"Element - {i}: ");
                    data[i] = Int32.Parse(Console.ReadLine());
                }
                Array.Sort(data);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Maximum element is: {data[data.Length - 1]}");
                Console.WriteLine($"Minimum element is: {data[0]}");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("\nWould you like to run this program again? y/n: ");
                char choiceP8 = Char.ToLower(Char.Parse(Console.ReadLine()));
                if (choiceP8 == 'y')
                {
                    goto P8;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Returning to Main Menu...");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    goto P_Start;
                }
            #endregion

            #region P_End
            P_End:
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Thank you for using this program. Press any key to close the console window...");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.ReadKey();
                #endregion
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.Yellow;                
                Console.WriteLine("\nReturning to Main Menu...");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine();
                Main(args);
            }          
        }
    }
}