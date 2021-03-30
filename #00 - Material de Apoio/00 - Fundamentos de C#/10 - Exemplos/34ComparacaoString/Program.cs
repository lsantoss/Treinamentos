using System;

namespace _34ComparacaoString
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto1 = "Hello World!";
            string texto2 = "Hello World!";
            string texto3 = "";
            string texto4 = " ";
            string texto5 = null;

            Console.WriteLine();
            Console.WriteLine("====== Comparação com == ou != ======");
            Console.WriteLine(texto1 == texto2);
            Console.WriteLine(texto1 != texto2);

            Console.WriteLine();
            Console.WriteLine("====== Comparação String.Equals ======");
            Console.WriteLine(String.Equals(texto1, texto2));
            Console.WriteLine(!String.Equals(texto1, texto2));

            Console.WriteLine();
            Console.WriteLine("====== Comparação StartsWith e EndsWith ======");
            Console.WriteLine(texto1.StartsWith("Hello"));
            Console.WriteLine(texto1.EndsWith("Hello"));

            Console.WriteLine();
            Console.WriteLine("====== Comparação IsNullOrEmpty ======");
            Console.WriteLine(string.IsNullOrEmpty(texto1));
            Console.WriteLine(string.IsNullOrEmpty(texto3));
            Console.WriteLine(string.IsNullOrEmpty(texto4));
            Console.WriteLine(string.IsNullOrEmpty(texto5));

            Console.WriteLine();
            Console.WriteLine("====== Comparação IsNullOrWhiteSpace ======");
            Console.WriteLine(string.IsNullOrWhiteSpace(texto1));
            Console.WriteLine(string.IsNullOrWhiteSpace(texto3));
            Console.WriteLine(string.IsNullOrWhiteSpace(texto4));
            Console.WriteLine(string.IsNullOrWhiteSpace(texto5));

            Console.WriteLine();
            Console.WriteLine("====== Comparação Contains ======");
            Console.WriteLine(texto1.Contains("Hello"));
            Console.WriteLine(texto1.Contains("Lucas123"));

            Console.ReadKey();
        }
    }
}