using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2._1
{
    abstract class Shape
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public abstract double CalculateArea();
    }

    class Circle:Shape
    {
        public int Radius { get; set; }
        public override double CalculateArea()
        {
            return Math.PI * (Radius * Radius);
        }
    }

    class Square:Shape
    {
        public int SideLength { get; set; }
        public override double CalculateArea()
        {
            return (SideLength * SideLength);
        }
    }
}
