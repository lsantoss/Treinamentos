using System;

namespace PolimorfismoSobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            Calcular calc = new Calcular();

            Console.WriteLine("Somando 2 números...");
            Console.WriteLine(calc.Soma(45, 43));

            Console.WriteLine();
            Console.WriteLine("Somando 3 números...");
            Console.WriteLine(calc.Soma(45, 43, 100));

            Console.ReadKey();
        }

        public class Calcular
        {
            public int Soma(int num1, int num2) => (num1 + num2);
            public int Soma(int num1, int num2, int num3) => (num1 + num2 + num3);
        }
    }
}