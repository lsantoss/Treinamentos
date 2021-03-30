using System;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();
            retangulo.InformarValores();
            retangulo.Exibir();
            Console.ReadKey();
        }

        public class Retangulo
        {
            private double comprimento;
            private double largura;

            public void InformarValores()
            {
                Console.Write("Informe o comprimento: ");
                comprimento = Convert.ToDouble(Console.ReadLine());
                Console.Write("Informe a largura: ");
                largura = Convert.ToDouble(Console.ReadLine());
            }

            public double GetArea() => comprimento * largura;

            public void Exibir()
            {
                Console.WriteLine();
                Console.WriteLine("===== Área do Retângulo ======");
                Console.WriteLine($"Comprimento: {comprimento}");
                Console.WriteLine($"Largura    : {largura}");
                Console.WriteLine($"Area       : {GetArea()}");
            }
        }
    }
}