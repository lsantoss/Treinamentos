using System;
using System.Collections.Generic;

namespace Exemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> frutasFavoritas = new List<string>();

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Digite a {i+1}° fruta: ");
                string fruta = Console.ReadLine();
                frutasFavoritas.Add(fruta);
            }

            Console.WriteLine();
            Console.WriteLine("Lista de frutas favoritas");
            for (int i = 0; i < frutasFavoritas.Count; i++)
            {
                Console.WriteLine($"{i+1}°: {frutasFavoritas[i]}");
            }

            Console.ReadKey();
        }
    }
}
