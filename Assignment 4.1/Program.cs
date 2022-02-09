using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4._1
{
    internal class Program
    {
        static void ReturnEvenNumbers()
        {
            int i;
            int n = 0;
            for (i = 0; i < 100; i++)
            {
                if ((n > 0) && (n%2 == 0))
                {
                    Console.Write($"{n} ");
                }
                n++;
            }
            Console.WriteLine(); 
        }

        static bool LeapYear(int y)
        {
            if (y % 4 == 0)
            {
                Console.WriteLine($"{y} is a leap year.");
                return true;
            }
            else
            {
                Console.WriteLine($"{y} is not a leap year.");
                return false;
            }           
        }

        static string ReverseString(string s)
        {
            char[] str = s.ToCharArray();
            string rs = string.Empty;
            for (int i = s.Length -1; i > -1; i--)
            {
                rs += str[i];
            }
            return rs;
        }

        static int CountSpaces(string strng)
        {
            int count = 0;
            foreach (char c in strng)
            {
                if (c == ' ')
                {
                    count++;
                }
            }
            return count;
        }

        static void Main(string[] args)
        {
            ReturnEvenNumbers();
            Console.ReadLine();

            Console.Write("Enter a year: ");
            LeapYear((Int32.Parse(Console.ReadLine())));
            Console.ReadLine();

            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            Console.WriteLine($"{input} in reverse is {ReverseString(input)}.");
            Console.ReadLine();

            Console.Write("Write a sentence: ");
            string sentence = Console.ReadLine();
            Console.WriteLine($"Your sentence contains {CountSpaces(sentence)} spaces.");
            Console.ReadLine(); 
        }
    }
}
