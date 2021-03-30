using System;
using System.Globalization;

namespace _38CultureInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            DateTime data = DateTime.Now;

            Console.WriteLine("==== Sem Formatação =====");
            Console.WriteLine(data);
            Console.WriteLine();

            Console.WriteLine("==== pt-BR =====");
            Console.WriteLine(data.ToString(CultureInfo.CreateSpecificCulture("pt-BR")));
            Console.WriteLine();

            Console.WriteLine("==== en-US =====");
            Console.WriteLine(data.ToString(CultureInfo.CreateSpecificCulture("en-US")));
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}