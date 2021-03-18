using System;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] notas = new decimal[4]; 

            Console.Write("Digite a primeira nota: ");
            notas[0] = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite a segunda nota : ");
            notas[1] = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            notas[2] = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite a quarta nota  : ");
            notas[3] = Convert.ToDecimal(Console.ReadLine());

            int lenght = notas.Length;
            decimal soma = notas[0] + notas[1] + notas[2] + notas[3];
            decimal media = soma / lenght;

            Console.WriteLine();
            Console.WriteLine($"Soma : {soma}");
            Console.WriteLine($"Média: {Math.Round(media, 2)}");
            Console.WriteLine($"Tamanho do vetor: {lenght}");

            Console.ReadKey();
        }
    }
}