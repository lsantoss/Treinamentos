using static System.Math;

namespace UsingStatic
{
    public class Circulo
    {
        public double Radius { get; set; }

        public Circulo(double radius)
        {
            Radius = radius;
        }

        public double Area
        {
            get { return PI * Pow(Radius, 2); }
        }
    }
}