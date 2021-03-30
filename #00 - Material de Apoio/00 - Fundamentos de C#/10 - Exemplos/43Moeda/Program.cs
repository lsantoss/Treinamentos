using System;
using System.Globalization;

namespace _43Moeda
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal valor = 7342587.5891m;

            Console.WriteLine("==== Culture local =====");
            Console.WriteLine(valor.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine(valor.ToString("C2", CultureInfo.CurrentCulture));
            Console.WriteLine(valor.ToString("C3", CultureInfo.CurrentCulture));
            Console.WriteLine(valor.ToString("C4", CultureInfo.CurrentCulture));
            Console.WriteLine(valor.ToString("C5", CultureInfo.CurrentCulture));

            Console.WriteLine();
            Console.WriteLine("==== Culture Japão =====");
            Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("ja-JP")));

            Console.WriteLine();
            Console.WriteLine("==== Culture Suécia =====");
            Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("se-SE")));

            Console.WriteLine();
            Console.WriteLine("==== Culture Argentina =====");
            Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("es-AG")));

            Console.WriteLine();
            Console.WriteLine("==== Exemplo N =====");
            Console.WriteLine(valor.ToString("N"));
            Console.WriteLine(valor.ToString("N1"));
            Console.WriteLine(valor.ToString("N2"));
            Console.WriteLine(valor.ToString("N3"));

            Console.WriteLine();
            Console.WriteLine("==== Exemplo Math =====");
            Console.WriteLine(Math.Round(valor));
            Console.WriteLine(Math.Round(valor, 1));
            Console.WriteLine(Math.Round(valor, 2));
            Console.WriteLine(Math.Round(valor, 3));

            Console.ReadKey();
        }
    }
}