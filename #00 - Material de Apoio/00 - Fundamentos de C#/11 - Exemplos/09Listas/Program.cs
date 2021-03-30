using System;
using System.Collections.Generic;

namespace _09Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listaNumeros = new List<int>() { 1, 55, 58, 12 };

            List<string> frutas = new List<string>();
            frutas.Add("Maçã");
            frutas.Add("Pera");
            frutas.Add("Uva");
            frutas.Add("Melão");
            frutas.Add("Morango");
            frutas.Add("Melância");

            Console.WriteLine("====== Números ======");
            Console.WriteLine(listaNumeros[0]);
            Console.WriteLine(listaNumeros[1]);
            Console.WriteLine(listaNumeros[2]);
            Console.WriteLine(listaNumeros[3]);
            Console.WriteLine(listaNumeros.Count);

            Console.WriteLine();
            Console.WriteLine("====== Frutas ======");
            Console.WriteLine(frutas[0]);
            Console.WriteLine(frutas[1]);
            Console.WriteLine(frutas[2]);
            Console.WriteLine(frutas[3]);
            Console.WriteLine(frutas[4]);
            Console.WriteLine(frutas[5]);
            Console.WriteLine(frutas.Count);

            Console.ReadKey();
        }
    }
}