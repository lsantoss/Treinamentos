using System;

namespace ExemploInterpolacao
{
    class Program
    {
        static void Main(string[] args)
        {
            var usuario = "lucas";
            var string1 = "C:\\Users\\lucas\\Documents";
            var string2 = $"C:\\Users\\{usuario}\\Documents";
            var string3 = $@"C:\Users\{usuario}\Documents";

            Console.WriteLine(string1);
            Console.WriteLine(string2);
            Console.WriteLine(string3);

            Console.ReadKey();
        }
    }
}