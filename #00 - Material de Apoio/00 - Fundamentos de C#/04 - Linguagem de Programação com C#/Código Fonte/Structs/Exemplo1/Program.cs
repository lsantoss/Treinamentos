using System;

namespace Exemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Coords coordenadas = new Coords(10, 20);

            Console.WriteLine(coordenadas.GetType());
            Console.WriteLine(coordenadas.ToString());

            Console.ReadKey();
        }

        private struct Coords
        {
            public double X { get; }
            public double Y { get; }

            public Coords(double x, double y)
            {
                X = x;
                Y = y;
            }

            public override string ToString()
            {
                return $"({X}, {Y})";
            }
        }
    }
}
