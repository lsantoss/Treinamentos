using System;

namespace ConversoesImplicitas
{
    class Program
    {
        static void Main(string[] args)
        {
            byte numeroByte = 5;

            short numeroShort = numeroByte;

            int numeroInt = numeroShort;

            long numeroLong = numeroInt;

            Console.WriteLine($"Número byte : {numeroByte}");
            Console.WriteLine($"Número short: {numeroShort}");
            Console.WriteLine($"Número int  : {numeroInt}");
            Console.WriteLine($"Número long : {numeroLong}");
            Console.ReadKey();
        }
    }
}