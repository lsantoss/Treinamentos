using System;

namespace ExemploComparacao
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = "Hello World";
            string string2 = "Hello World";
            string string3 = ""; //----> string.Empty;
            string string4 = " ";
            string string5 = null;

            Console.WriteLine();
            Console.WriteLine("===== Coparação com == e != ==========");
            Console.WriteLine(string1 == string2);
            Console.WriteLine(string1 != string2);

            Console.WriteLine();
            Console.WriteLine("===== Coparação com Equals ==========");
            Console.WriteLine(String.Equals(string1, string2));
            Console.WriteLine(!String.Equals(string1, string2));

            Console.WriteLine();
            Console.WriteLine("===== Coparação com StartsWith, EndsWith ==========");
            Console.WriteLine(string1.StartsWith("Hello"));
            Console.WriteLine(string1.EndsWith("Hello"));

            Console.WriteLine();
            Console.WriteLine("===== Coparação IsNullOrEmpty ==========");
            Console.WriteLine(string.IsNullOrEmpty(string1));
            Console.WriteLine(string.IsNullOrEmpty(string3));
            Console.WriteLine(string.IsNullOrEmpty(string4));
            Console.WriteLine(string.IsNullOrEmpty(string5));

            Console.WriteLine();
            Console.WriteLine("===== Coparação IsNullOrEmpty ==========");
            Console.WriteLine(string.IsNullOrWhiteSpace(string1));
            Console.WriteLine(string.IsNullOrWhiteSpace(string3));
            Console.WriteLine(string.IsNullOrWhiteSpace(string4));
            Console.WriteLine(string.IsNullOrWhiteSpace(string5));

            Console.ReadKey();
        }
    }
}
