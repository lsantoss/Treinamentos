using System;

namespace Constantes
{
    class Program
    {

        static void Main(string[] args)
        {
            const double pi = 3.14159;

            //valor de pi não pode ser alterardo
            //pi = 5.5;

            Console.Write("Digite o raio: ");
            double raio = Convert.ToDouble(Console.ReadLine());

            double area = pi * (raio * raio);

            Console.WriteLine();
            Console.WriteLine($"Área: {area}");
            Console.ReadKey();
        }
    }
}