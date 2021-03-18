using System;

namespace Inteiros
{
    class Program
    {
        static void Main(string[] args)
        {
            //valor padrão = 0; não pode ser null
            int valorPadrao;

            Console.Write("Digite o primeiro número: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            int adicao = numero1 + numero2;
            int subtracao = numero1 - numero2;
            int multiplicacao = numero1 * numero2;
            int divisao = numero1 / numero2;

            Console.WriteLine($"Adição: {adicao}");
            Console.WriteLine($"Subtração: {subtracao}");
            Console.WriteLine($"Multiplicação: {multiplicacao}");
            Console.WriteLine($"Divisão: {divisao}");

            Console.ReadKey();
        }
    }
}