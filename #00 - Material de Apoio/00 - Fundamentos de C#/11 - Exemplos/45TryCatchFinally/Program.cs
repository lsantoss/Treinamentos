﻿using System;

namespace _45TryCatchFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 100;
            int numero2 = 5;
            double resultado = 0;

            try
            {
                resultado = numero1 / numero2;
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine($"Erro aritmético: {e.Message}");
                Console.WriteLine();
                Console.WriteLine(e);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro genérico: {e.Message}");
                Console.WriteLine();
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine();
                Console.WriteLine($"Resultado: {resultado}");
                Console.WriteLine("Esse bloco de código será sempre executado, com sucesso ou falha");
            }

            Console.ReadKey();
        }
    }
}