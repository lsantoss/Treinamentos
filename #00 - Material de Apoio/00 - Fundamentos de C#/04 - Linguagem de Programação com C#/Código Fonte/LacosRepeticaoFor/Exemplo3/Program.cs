using System;
using System.Collections.Generic;

namespace Exemplo3
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
            for (int i = 0; i < listaSalarios.Count; i++)
            {
                Console.WriteLine(listaSalarios[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Lista de salários acima de 2000,00");
            for (int i = 0; i < listaSalarios.Count; i++)
            {
                if (listaSalarios[i] > 2000)
                {
                    Console.WriteLine(listaSalarios[i]);
                }
            }

            Console.ReadKey();
        }
    }
}
