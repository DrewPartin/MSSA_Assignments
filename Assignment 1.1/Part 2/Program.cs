using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNum = 5;
            float flNum = 35.1F;
            decimal decNum = 45.33M;
            double dblNum = 17.45823;

            Console.WriteLine("The minimum value of an integer is: " + int.MinValue + ".");
            Console.WriteLine("The maximum value of an integer is: " + int.MaxValue + ".");
            Console.WriteLine(iNum + " is an acceptable intiger value.");
            Console.WriteLine("");
            Console.WriteLine("The minimum value of a floating point variable is: " + float.MinValue + ".");
            Console.WriteLine("The maximum value of a floating point variable is: " + float.MaxValue + ".");
            Console.WriteLine(flNum + " is an acceptable float value.");
            Console.WriteLine("");
            Console.WriteLine("The minimum value of a decimal number is: " + decimal.MinValue + ".");
            Console.WriteLine("The maximum value of a decimal number is: " + decimal.MaxValue + ".");
            Console.WriteLine(decNum + " is an acceptable decimal value.");
            Console.WriteLine("");
            Console.WriteLine("The minimum value of a double variable is: " + double.MinValue + ".");
            Console.WriteLine("The maximum value of a double variable is: " + double.MaxValue + ".");
            Console.WriteLine(dblNum + " is an acceptable double value.");
            Console.ReadLine();
        }
    }
}
