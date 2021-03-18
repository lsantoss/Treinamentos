using System;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //valor padão de um inteiro = 0
            int inteiro0;

            //valor padão de um inteiro usando default = 0
            int inteiro1 = default;

            //setando valor em um inteiro = 2
            int inteiro2 = 2;

            //valor padão de um inteiro nullable = null
            int? inteiro3;

            //valor padão de um inteiro usando default = null
            int? inteiro4 = default;

            //setando valor em um inteiro nullable = 5
            int? inteiro5 = 5;

            //setando valor em um inteiro nullable de inteiro não nullable = 2
            int? inteiro6 = inteiro2;

            //Console.WriteLine($"Inteiro 0: {inteiro0}"); //variável local não atribuída
            Console.WriteLine($"Inteiro 1: {inteiro1}");
            Console.WriteLine($"Inteiro 2: {inteiro2}");
            //Console.WriteLine($"Inteiro 3: {inteiro3}"); //variável local não atribuída
            Console.WriteLine($"Inteiro 4: {inteiro4}");
            Console.WriteLine($"Inteiro 5: {inteiro5}");
            Console.WriteLine($"Inteiro 6: {inteiro6}");
            Console.ReadKey();
        }
    }
}