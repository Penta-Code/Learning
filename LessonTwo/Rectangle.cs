using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonTwo
{
    class Rectangle
    {
        private double side1, side2;
        
        public double Area { get; }
        public double Perimetr { get; }

        public Rectangle()
        {

        }

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public double AreaCalculator()
        {
            return side1 * side2;
        }

        public double PerimetrCalculator()
        {
            return 2 * (side1 + side2);
        }

        public override string ToString()
        {
            return $"P and S = {PerimetrCalculator()} and {AreaCalculator()}";
        }
    }
}