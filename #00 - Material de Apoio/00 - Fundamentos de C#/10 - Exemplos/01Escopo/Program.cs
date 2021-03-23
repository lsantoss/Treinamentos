using System;

namespace _01Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine(nome);

            Console.ReadKey();
        }
    }
}