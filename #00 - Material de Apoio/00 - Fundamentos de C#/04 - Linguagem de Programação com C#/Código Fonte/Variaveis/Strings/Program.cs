using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //valor padrão = null
            string valorPadrao;

            Console.Write("Digite o primeiro nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o segundo nome: ");
            string sobrenome = Console.ReadLine();

            string nomeCompleto = nome + " " + sobrenome; 
            char char1 = nomeCompleto[3];
            int lenght = nomeCompleto.Length;

            Console.WriteLine();
            Console.WriteLine($"Primeiro nome   : {nome}");
            Console.WriteLine($"Segundo nome    : {sobrenome}");
            Console.WriteLine($"Nome complento  : {nomeCompleto}");
            Console.WriteLine($"Quarto caracter : {char1}");
            Console.WriteLine($"Tamanho do nome : {lenght}");

            Console.ReadKey();
        }
    }
}