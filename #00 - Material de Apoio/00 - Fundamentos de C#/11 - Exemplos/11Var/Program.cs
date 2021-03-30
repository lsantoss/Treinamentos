using System;
using System.Collections.Generic;

namespace _11Var
{
    class Program
    {
        static void Main(string[] args)
        {
            var varInteiro = 1;
            var varFloat = 2.5f;
            var varDouble = 2.5;
            var varDecimal = 17.6m;
            var varString = "Texto";
            var varChar = 'a';
            var varList = new List<int>();

            Console.WriteLine(varInteiro);
            Console.WriteLine(varFloat);
            Console.WriteLine(varDouble);
            Console.WriteLine(varDecimal);
            Console.WriteLine(varString);
            Console.WriteLine(varChar);
            Console.WriteLine(varList);
            Console.ReadKey();
        }
    }
}