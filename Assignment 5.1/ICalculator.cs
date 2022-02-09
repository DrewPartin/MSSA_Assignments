using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5._1
{
    interface ICalculator
    {
        decimal AddNumbers(decimal num1, decimal num2);
        decimal SubtractNumbers(decimal num1, decimal num2);
        decimal MultiplyNumbers(decimal num1, decimal num2);
        decimal DivideNumbers(decimal num1, decimal num2);
    }

    public class Calculator : ICalculator
    {
        public decimal AddNumbers(decimal num1, decimal num2)
        {
            return num1 + num2;
        }
        public decimal SubtractNumbers(decimal num1, decimal num2)
        {
            return num1 - num2;
        }
        public decimal MultiplyNumbers(decimal num1, decimal num2)
        {
            return num1 * num2;
        }
        public decimal DivideNumbers(decimal num1, decimal num2)
        {
            try
            {
                if (num2 != 0)
                {
                    return num1 / num2;
                }
                else
                {
                    throw new DivideByZeroException();
                }
            }
            catch(DivideByZeroException ex)
            {
                return 0;
            }
            
        }
    }

    
}
