using System;

namespace _08Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = { 1, 55, 58, 12 };

            string[] frutas = new string[4];
            frutas[0] = "Maçã";
            frutas[1] = "Pera";
            frutas[2] = "Uva";
            frutas[3] = "Melão";

            Console.WriteLine("====== Números ======");
            Console.WriteLine(vetor[0]);
            Console.WriteLine(vetor[1]);
            Console.WriteLine(vetor[2]);
            Console.WriteLine(vetor[3]);
            Console.WriteLine(vetor.Length);

            Console.WriteLine();
            Console.WriteLine("====== Frutas ======");
            Console.WriteLine(frutas[0]);
            Console.WriteLine(frutas[1]);
            Console.WriteLine(frutas[2]);
            Console.WriteLine(frutas[3]);
            Console.WriteLine(frutas.Length);

            Console.ReadKey();
        }
    }
}