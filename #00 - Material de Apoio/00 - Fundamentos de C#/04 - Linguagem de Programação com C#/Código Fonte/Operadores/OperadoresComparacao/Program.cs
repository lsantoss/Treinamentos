﻿using System;

namespace OperadoresComparacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("========= Operador menor que < ===========");
            Console.WriteLine(7 < 5); //False
            Console.WriteLine(5 < 5); //False
            Console.WriteLine(0 < 5); //True

            Console.WriteLine();
            Console.WriteLine("========= Operador maior que > ===========");
            Console.WriteLine(7 > 5); //True
            Console.WriteLine(5 > 5); //False
            Console.WriteLine(0 > 5); //False

            Console.WriteLine();
            Console.WriteLine("========= Operador menor ou igual <= ===========");
            Console.WriteLine(7 <= 5); //False
            Console.WriteLine(5 <= 5); //True
            Console.WriteLine(0 <= 5); //True

            Console.WriteLine();
            Console.WriteLine("========= Operador maior ou igual >= ===========");
            Console.WriteLine(7 >= 5); //True
            Console.WriteLine(5 >= 5); //True
            Console.WriteLine(0 >= 5); //False

            Console.WriteLine();
            Console.WriteLine("========= Operador de igualdade == ===========");
            Console.WriteLine(7 == 5); //False
            Console.WriteLine(5 == 5); //True
            Console.WriteLine(0 == 5); //False

            Console.WriteLine();
            Console.WriteLine("========= Operador de desigualdade != ===========");
            Console.WriteLine(7 != 5); //True
            Console.WriteLine(5 != 5); //False
            Console.WriteLine(0 != 5); //True

            Console.ReadKey();
        }
    }
}