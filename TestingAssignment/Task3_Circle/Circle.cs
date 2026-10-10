using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingAssignment.Task3_Circle
{
    public class Circle
    {
        public double Radius { get; set; }
        public double X { get; set; }
        public double Y { get; set; }

        public Circle(double radius, double x, double y)
        {
            if (radius <= 0)
                throw new ArgumentException("Радиус должен быть больше нуля");
            Radius = radius;
            X = x;
            Y = y;
        }

        public double CalculateArcLength(double angleDegrees)
        {
            return (2 * Math.PI * Radius * angleDegrees) / 360.0;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public bool ContainsPoint(double pointX, double pointY)
        {
            double distanceSquared = Math.Pow(pointX - X, 2) + Math.Pow(pointY - Y, 2);
            return distanceSquared <= Math.Pow(Radius, 2);
        }
    }
}