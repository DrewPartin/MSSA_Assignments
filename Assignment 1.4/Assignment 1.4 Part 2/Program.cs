using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._4_Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            start:
            Student st1 = new Student();
            Random id = new Random();
            st1.student_id = id.Next(1, 2000);

            Console.Write("Enter the student's first name: ");
            st1.student_fname = Console.ReadLine();
            Console.Write("Enter the student's last name: ");
            st1.student_lname = Console.ReadLine(); 
            st1.CalculateGrade();
            
            Console.WriteLine("Student information is: ");
            Console.WriteLine("ID#:         " + st1.student_id);
            Console.WriteLine("First Name:  " + st1.student_fname);
            Console.WriteLine("Last Name:   " + st1.student_lname);
            Console.WriteLine("Grade:       " + st1.student_grade);
            Console.WriteLine("");
            Console.WriteLine("Would you like to enter data for another student?");
            if (Convert.ToChar(Console.ReadLine().ToLower()) == 'y')
            {
                goto start;
            }
            else
            {
                Console.WriteLine("Press Enter to close this application. Goodbye.");
                Console.ReadKey();
            }
        }
    }
}
