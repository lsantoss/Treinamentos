using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> notas = new List<decimal>();

            Console.Write("Digite a primeira nota: ");
            notas.Add(Convert.ToDecimal(Console.ReadLine()));

            Console.Write("Digite a segunda nota : ");
            notas.Add(Convert.ToDecimal(Console.ReadLine()));

            Console.Write("Digite a terceira nota: ");
            notas.Add(Convert.ToDecimal(Console.ReadLine()));

            Console.Write("Digite a quarta nota  : ");
            notas.Add(Convert.ToDecimal(Console.ReadLine()));

            int lenght = notas.Count;
            decimal soma = notas[0] + notas[1] + notas[2] + notas[3];
            decimal media = soma / lenght;

            Console.WriteLine();
            Console.WriteLine($"Soma : {soma}");
            Console.WriteLine($"Média: {Math.Round(media, 2)}");
            Console.WriteLine($"Tamanho da lista: {lenght}");

            Console.ReadKey();
        }
    }
}