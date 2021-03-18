using System;

namespace UsingStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            Circulo circulo = new Circulo(5);

            Console.WriteLine(circle.Area);
            Console.WriteLine(circulo.Area);

            Console.ReadKey();
        }
    }
}