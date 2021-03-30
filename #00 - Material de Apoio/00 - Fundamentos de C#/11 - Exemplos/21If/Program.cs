using System;

namespace _21If
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite sua cor favorita: ");
            string cor = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("==== If com chaves ======");
            if (cor == "azul")
            {
                Console.WriteLine("Sua cor favorita é azul");
            }

            Console.WriteLine();
            Console.WriteLine("==== If sem chaves (somente uma linha) ======");
            if (cor == "azul")
                Console.WriteLine("Sua cor favorita é azul");

            Console.WriteLine();
            Console.WriteLine("==== If-else com chaves ======");
            if (cor == "azul")
            {
                Console.WriteLine("Sua cor favorita é azul");
            }
            else
            {
                Console.WriteLine("Cor desconhecida");
            }

            Console.WriteLine();
            Console.WriteLine("==== If-else sem chaves (somente uma linha em cada) ======");
            if (cor == "azul")
                Console.WriteLine("Sua cor favorita é azul");
            else
                Console.WriteLine("Cor desconhecida");

            Console.WriteLine();
            Console.WriteLine("==== else-if com chaves ======");
            if (cor == "azul")
            {
                Console.WriteLine("Sua cor favorita é azul");
            }
            else if (cor == "preto")
            {
                Console.WriteLine("Sua cor favorita é preto");
            }
            else if (cor == "amarelo")
            {
                Console.WriteLine("Sua cor favorita é amarelo");
            }
            else if (cor == "vermelho")
            {
                Console.WriteLine("Sua cor favorita é vermelho");
            }
            else
            {
                Console.WriteLine("Cor desconhecida");
            }

            Console.WriteLine();
            Console.WriteLine("==== else-if sem chaves (somente uma linha em cada) ======");
            if (cor == "azul")
                Console.WriteLine("Sua cor favorita é azul");
            else if (cor == "preto")
                Console.WriteLine("Sua cor favorita é preto");
            else if (cor == "amarelo")
                Console.WriteLine("Sua cor favorita é amarelo");
            else if (cor == "vermelho")
                Console.WriteLine("Sua cor favorita é vermelho");
            else
                Console.WriteLine("Cor desconhecida");

            Console.WriteLine();
            Console.WriteLine("==== If ternário ======");
            string texto = cor == "azul" ? "Sua cor favorita é azul" : "Cor desconhecida";
            Console.WriteLine(texto);

            Console.ReadKey();
        }
    }
}