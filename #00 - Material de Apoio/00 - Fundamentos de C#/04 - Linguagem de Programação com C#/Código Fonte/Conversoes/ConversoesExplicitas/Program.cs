using System;

namespace ConversoesExplicitas
{
    class Program
    {
        static void Main(string[] args)
        {
            long numeroLong = 17;
            int numeroInt = (int)numeroLong;
            short numeroShort = (short)numeroInt;
            byte numeroByte = (byte)numeroShort;

            //int numeroDeUmaString = (int)"1";

            Console.WriteLine($"Número byte : {numeroByte}");
            Console.WriteLine($"Número short: {numeroShort}");
            Console.WriteLine($"Número int  : {numeroInt}");
            Console.WriteLine($"Número long : {numeroLong}");
            Console.WriteLine();

            decimal numeroDecimal = 6.5m;
            double numeroDouble = (double)numeroDecimal;
            float numeroFloat = (float)numeroDouble;

            Console.WriteLine($"Número float  : {numeroFloat}");
            Console.WriteLine($"Número double : {numeroDouble}");
            Console.WriteLine($"Número decimal: {numeroDecimal}");
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}