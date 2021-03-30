using System;

namespace _07StringObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o seu nome completo: ");
            string nome = Console.ReadLine();

            object nomeEmObject = nome;

            nome = nome + "123" + "Teste";

            char caracter = nome[5];

            int quantidade = nome.Length;

            Console.WriteLine();
            Console.WriteLine(nome);
            Console.WriteLine(nomeEmObject);
            Console.WriteLine(caracter);
            Console.WriteLine(quantidade);

            Console.ReadKey();
        }
    }
}
