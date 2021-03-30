using System;

namespace _30Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Coords coordenadas = new Coords(10, 20);

            Console.WriteLine(coordenadas.X);
            Console.WriteLine(coordenadas.Y);
            Console.WriteLine(coordenadas.ToString());
            Console.WriteLine(coordenadas.GetType());

            Console.ReadKey();
        }
    }
}