using System;
using System.Globalization;

namespace TiposMoeda
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal valor = 7342587.5891m;

            //Cultura atual
            Console.WriteLine("\n--------- Exibindo Moeda na cultura atual ---------------\n");
            // Por padrão, o especificador de formato "C" exibe a mode até duas casas decimais
            Console.WriteLine(valor.ToString("C", CultureInfo.CurrentCulture));
            // C2 exibe a moeda até dois digitos
            Console.WriteLine(valor.ToString("C2", CultureInfo.CurrentCulture));
            // C3 exibe a moeda até 3 digitos
            Console.WriteLine(valor.ToString("C3", CultureInfo.CurrentCulture));
            // C4 exibe a moeda até 4 digitos
            Console.WriteLine(valor.ToString("C4", CultureInfo.CurrentCulture));
            // C5 exibe a moeda até 5 digitos
            Console.WriteLine(valor.ToString("C5", CultureInfo.CurrentCulture));

            //Para o Japão
            Console.WriteLine("\n--------- Exibe a moeda para o Japão ---------------\n");
            Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("ja-JP")));

            //Para a Suécia
            Console.WriteLine("\n--------- Exibe a moeda para a Suécia---------------\n");
            Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("se-SE")));

            //Para a Argentina
            Console.WriteLine("\n--------- Exibe a moeda para a Argentina  --------------\n");
            Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("es-AG")));

            // Exemplo com N...
            Console.WriteLine("\n--------- Exemplo com N...  --------------\n");
            Console.WriteLine(valor.ToString("N"));
            Console.WriteLine(valor.ToString("N1"));
            Console.WriteLine(valor.ToString("N2"));
            Console.WriteLine(valor.ToString("N3"));

            // Exemplo com Math
            Console.WriteLine("\n--------- Exemplo com Math  --------------\n");
            Console.WriteLine(Math.Round(valor));
            Console.WriteLine(Math.Round(valor, 1));
            Console.WriteLine(Math.Round(valor, 2));
            Console.WriteLine(Math.Round(valor, 3));

            Console.ReadKey();
        }
    }
}