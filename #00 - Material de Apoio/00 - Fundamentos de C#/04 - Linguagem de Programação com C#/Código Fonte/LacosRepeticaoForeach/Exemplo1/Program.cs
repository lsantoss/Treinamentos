using System;
using System.Collections.Generic;

namespace Exemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> listaSalarios = new List<decimal>();

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Digite o salário: ");
                decimal salario = Convert.ToDecimal(Console.ReadLine());
                listaSalarios.Add(salario);
            }


            Console.WriteLine();
            Console.WriteLine("Lista de salários");
            foreach (var salaraioAtual in listaSalarios)
            {
                Console.WriteLine(salaraioAtual);
            }

            Console.WriteLine();
            Console.WriteLine("Lista de salários acima de 2000,00");
            foreach (var salaraioAtual in listaSalarios)
            {
                if (salaraioAtual > 2000)
                {
                    Console.WriteLine(salaraioAtual);
                }
            }

            Console.ReadKey();
        }
    }
}