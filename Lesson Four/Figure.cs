using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_Four
{
    public class Figure
    {
        Point[] points;
        string type = " ";
        public string Type { set { Type = ""; } get { return type; } }

        public Figure(Point pointA, Point pointB, Point pointC)
        {
            points = new Point[3];
            points[0] = pointA;
            points[1] = pointB;
            points[2] = pointC;
            type = "Triangle";
        }

        public Figure(Point pointA, Point pointB, Point pointC, Point pointD)
        {
            points = new Point[4];
            points[0] = pointA;
            points[1] = pointB;
            points[2] = pointC;
            points[3] = pointD;
            type = "Tetragon";
        }

        public Figure(Point pointA, Point pointB, Point pointC, Point pointD, Point pointE)
        {
            points = new Point[5];
            points[0] = pointA;
            points[1] = pointB;
            points[2] = pointC;
            points[3] = pointD;
            points[4] = pointE;
            type = "Pentagon";
        }

        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow((B.Y - A.Y), 2) + Math.Pow((B.X - A.X), 2));
        }

        public void PerimeterCalculator()
        {
            double sum = 0;

            for (int i = 0; i < points.Length - 1; i++)
            {
                sum += LengthSide(points[i], points[i + 1]);
            }

            sum += LengthSide(points[points.Length - 1], points[0]);
            Console.Write(sum);
        }
    }
}
