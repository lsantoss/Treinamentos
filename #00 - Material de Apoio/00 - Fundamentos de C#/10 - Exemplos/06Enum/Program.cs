using System;

namespace _06Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            ESituacao situacao;

            situacao = ESituacao.Aberto;
            Console.WriteLine($"Situação atual: {situacao.GetHashCode()}");
            Console.WriteLine($"Situação atual: {situacao}");

            situacao = ESituacao.Faturado;
            Console.WriteLine();
            Console.WriteLine($"Situação atual: {situacao.GetHashCode()}");
            Console.WriteLine($"Situação atual: {situacao}");

            situacao = ESituacao.Cancelado;
            Console.WriteLine($"\nSituação atual: {situacao.GetHashCode()}");
            Console.WriteLine($"Situação atual: {situacao}");

            Console.ReadKey();
        }
    }
}