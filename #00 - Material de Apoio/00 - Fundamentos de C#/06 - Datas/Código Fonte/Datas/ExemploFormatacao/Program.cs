using System;

namespace ExemploFormatacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            DateTime date1 = DateTime.Now;
            Console.WriteLine(date1);
            Console.WriteLine(date1.ToString(System.Globalization.CultureInfo.CreateSpecificCulture("pt-BR")));

            Console.ReadKey();
        }
    }
}