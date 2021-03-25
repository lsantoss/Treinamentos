using System;
using System.Collections.Generic;

namespace _24For
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> frutas = new List<string>();

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Digite a {i+1}° fruta: ");
                string fruta = Console.ReadLine();
                frutas.Add(fruta);
            }

            Console.WriteLine();
            Console.WriteLine("Lista de frutas");
            for (int i = 0; i < frutas.Count; i++)
            {
                Console.WriteLine($"{i+1}°: {frutas[i]}");
            }


            Console.ReadKey();
        }
    }
}