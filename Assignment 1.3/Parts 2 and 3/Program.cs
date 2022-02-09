using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._3__number_2_and_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array;

            Console.Write("Enter the number of elements in your array: ");
            int size = Int32.Parse(Console.ReadLine());
            array = new int[size];
            Console.WriteLine($"Enter your {size} elements below: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Element {i + 1}: ");
                array[i] = Int32.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("The values stored in the array are: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.ReadLine();

            Console.WriteLine("The values stored in the array in reverse are: ");
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write(array[i] + " ");
            }
            Console.ReadLine();

            int[] array2;
            array2 = new int[5];

            Console.WriteLine("Enter 5 random numbers between 0 and 25");
            for (int a = 0; a < 5; a++)
            {
                Console.Write($"Element {a + 1}: ");
                array2[a] = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine("The values stored in this array in the order received are: ");
            for (int a = 0; a < 5; a++)
            {
                Console.Write(array2[a] + " ");
            }
            Console.ReadLine();
            
            Array.Sort(array2);
            Console.WriteLine("The values stored in this array in ascending order are: ");
            for (int s = 0; s < 5; s++)
            {
                Console.Write(array2[s] + " ");
            }
            Console.ReadLine();

        }
    }
}
