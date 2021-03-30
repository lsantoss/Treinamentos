using System;

namespace 33InterpolacaoString
{
    class Program
    {
        static void Main(string[] args)
        {
            var usuario = "l_san";
            var caminho1 = "C:\\Users\\l_san\\Documents\\GitHub\\Treinamentos";
            var caminho2 = $"C:\\Users\\{usuario}\\Documents\\GitHub\\Treinamentos";
            var caminho3 = $@"C:\Users\{usuario}\Documents\GitHub\Treinamentos";

            var text1 = "Primeira linha\n" +
                        "Segunda linha";

            var text2 = @"Primeira linha
                          Segunda linha";

            Console.WriteLine(caminho1);
            Console.WriteLine(caminho2);
            Console.WriteLine(caminho3);
            Console.WriteLine();
            Console.WriteLine(text1);
            Console.WriteLine();
            Console.WriteLine(text2);

            Console.ReadKey();
        }
    }
}