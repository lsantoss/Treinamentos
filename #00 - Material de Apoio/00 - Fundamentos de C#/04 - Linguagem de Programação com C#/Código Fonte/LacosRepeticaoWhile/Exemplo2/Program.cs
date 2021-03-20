﻿using System;
using System.Collections.Generic;

namespace Exemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nomes = new List<string>();
            bool flag = true;

            while (flag)
            {
                Console.Write("Digite um nome: ");
                string nome = Console.ReadLine();
                nomes.Add(nome);

                Console.Write("Deseja encerrar? (s) ou (n): ");
                char resposta = Convert.ToChar(Console.ReadLine());
                if (resposta == 's')
                    flag = false;
                else
                    flag = true;

                Console.WriteLine();
            }


            int contador = 0;
            Console.WriteLine("Lista de nomes");
            while (contador < nomes.Count)
            {
                Console.WriteLine($"{nomes[contador]}");
                contador++;
            }

            Console.ReadKey();
        }
    }
}