using System;

namespace Flutuantes
{
    class Program
    {
        static void Main(string[] args)
        {
            //valor padrão = 0; não pode ser null
            decimal valorPadrao;

            Console.Write("Digite o primeiro número: ");
            decimal numero1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            decimal numero2 = Convert.ToDecimal(Console.ReadLine());

            decimal adicao = numero1 + numero2;
            decimal subtracao = numero1 - numero2;
            decimal multiplicacao = numero1 * numero2;
            decimal divisao = numero1 / numero2;

            Console.WriteLine($"Adição: {adicao}");
            Console.WriteLine($"Subtração: {subtracao}");
            Console.WriteLine($"Multiplicação: {multiplicacao}");
            Console.WriteLine($"Divisão: {Math.Round(divisao, 2)}");

            Console.ReadKey();
        }
    }
}