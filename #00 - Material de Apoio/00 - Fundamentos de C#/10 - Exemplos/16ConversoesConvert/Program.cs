using System;

namespace _16ConversoesConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            string numeroEmString = "150";
            int inteiro = Convert.ToInt32(numeroEmString);

            numeroEmString = "155,55";
            double varDouble = Convert.ToDouble(numeroEmString);

            double double2 = Convert.ToDouble(inteiro);

            Console.WriteLine(numeroEmString);
            Console.WriteLine(inteiro);
            Console.WriteLine(varDouble);
            Console.WriteLine(double2);
            Console.ReadKey();
        }
    }
}