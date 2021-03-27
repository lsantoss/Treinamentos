using System;

namespace ExemploCultureInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            DateTime date1 = DateTime.Now;

            Console.WriteLine("====== Sem formatação ======");
            Console.WriteLine(date1);
            Console.WriteLine();

            Console.WriteLine("====== pt-BR ======");
            Console.WriteLine(date1.ToString(System.Globalization.CultureInfo.CreateSpecificCulture("pt-BR")));
            Console.WriteLine();

            Console.WriteLine("====== en-US ======");
            Console.WriteLine(date1.ToString(System.Globalization.CultureInfo.CreateSpecificCulture("en-US")));
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
