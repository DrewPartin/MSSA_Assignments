using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            float age;
            
            string firstName;
            string address;

            Console.WriteLine("Please enter your name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Please enter your age as a whole number: ");
            age = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Please enter your address: ");
            address = Console.ReadLine();
            Console.ReadLine();

            Console.WriteLine("Your information is:" );
            Console.WriteLine("Name: " + firstName);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Address: " + address);
            Console.ReadLine();
        }
    }
}