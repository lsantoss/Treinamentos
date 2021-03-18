using System;

namespace ConversoesConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            string inteiroEmString = "15";
            string flutuanteEmString = "7,59";

            byte numeroByte = Convert.ToByte(inteiroEmString);
            short numeroShort = Convert.ToInt16(inteiroEmString);
            int numeroInt = Convert.ToInt32(inteiroEmString);
            long numeroLong = Convert.ToInt64(inteiroEmString);

            Console.WriteLine($"Número byte : {numeroByte}");
            Console.WriteLine($"Número short: {numeroShort}");
            Console.WriteLine($"Número int  : {numeroInt}");
            Console.WriteLine($"Número long : {numeroLong}");
            Console.WriteLine();

            float numeroFloat = Convert.ToSingle(flutuanteEmString);
            double numeroDouble = Convert.ToDouble(flutuanteEmString);
            decimal numeroDecimal = Convert.ToDecimal(flutuanteEmString);

            Console.WriteLine($"Número float  : {numeroFloat}");
            Console.WriteLine($"Número double : {numeroDouble}");
            Console.WriteLine($"Número decimal: {numeroDecimal}");
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}