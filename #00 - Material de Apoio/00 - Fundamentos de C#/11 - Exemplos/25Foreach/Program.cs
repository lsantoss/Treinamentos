using System;
using System.Collections.Generic;

namespace _25Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> listaSalarios = new List<decimal>();

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Digite o seu salário: ");
                decimal salario = Convert.ToDecimal(Console.ReadLine());
                listaSalarios.Add(salario);
            }

            Console.WriteLine();
            Console.WriteLine("Lista de salários");
            foreach (var salario in listaSalarios)
            {
                Console.WriteLine(salario.ToString("C"));
            }

            Console.WriteLine();
            Console.WriteLine("Lista de salários > 2000");
            foreach (var salario in listaSalarios)
            {
                if (salario > 2000)
                {
                    Console.WriteLine(salario.ToString("C"));
                }
            }

            Console.ReadKey();
        }
    }
}