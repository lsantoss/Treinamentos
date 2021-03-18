using System;

namespace UsingStatic
{
    public class Circle
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Area
        {
            get { return Math.PI * Math.Pow(Radius, 2); }
        }
    }
}