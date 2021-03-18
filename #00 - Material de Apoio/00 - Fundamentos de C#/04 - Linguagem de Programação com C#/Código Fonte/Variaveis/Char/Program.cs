using System;

namespace Char
{
    class Program
    {
        static void Main(string[] args)
        {
            //valor padrão = '\0'; não pode ser null; somente um caracter entre ''
            char valorPadrao;

            Console.Write("Digite o seu sexo (M/F): ");
            char sexo = Convert.ToChar(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"O sexo é: {sexo}");
            Console.ReadKey();
        }
    }
}