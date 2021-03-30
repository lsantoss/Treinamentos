using System;

namespace _15ConversoesParse
{
    class Program
    {
        static void Main(string[] args)
        {
            string numeroEmString = "150";
            int inteiro = Int32.Parse(numeroEmString);

            numeroEmString = "155,55";
            double varDouble = Double.Parse(numeroEmString);

            Console.WriteLine(numeroEmString);
            Console.WriteLine(inteiro);
            Console.WriteLine(varDouble);
            Console.ReadKey();
        }
    }
}