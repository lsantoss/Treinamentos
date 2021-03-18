using System;

namespace ConversoesParse
{
    class Program
    {
        static void Main(string[] args)
        {
            string numeroEmString = "15";
            string flutuanteEmString = "7,59";

            byte numeroByte = Byte.Parse(numeroEmString);
            short numeroShort = Int16.Parse(numeroEmString);
            int numeroInt = Int32.Parse(numeroEmString);
            long numeroLong = Int64.Parse(numeroEmString);

            Console.WriteLine($"Número byte : {numeroByte}");
            Console.WriteLine($"Número short: {numeroShort}");
            Console.WriteLine($"Número int  : {numeroInt}");
            Console.WriteLine($"Número long : {numeroLong}");
            Console.WriteLine();

            float numeroFloat = Single.Parse(flutuanteEmString);
            double numeroDouble = Double.Parse(flutuanteEmString);
            decimal numeroDecimal = Decimal.Parse(flutuanteEmString);

            Console.WriteLine($"Número float  : {numeroFloat}");
            Console.WriteLine($"Número double : {numeroDouble}");
            Console.WriteLine($"Número decimal: {numeroDecimal}");
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}