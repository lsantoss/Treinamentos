using System;

namespace OperadorIF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite sua cor favorita: ");
            string cor = Console.ReadLine();

            //==================If com chaves=============================
            if (cor == "azul")
            {
                Console.WriteLine("Sua cor favorita é azul");
            }



            //==================If sem chaves (somente 1 linha)=============================
            if (cor == "azul")
                Console.WriteLine("Sua cor favorita é azul");



            //==================If-else com chaves=============================
            if (cor == "azul")
            {
                Console.WriteLine("Sua cor favorita é azul");
            }
            else
            {
                Console.WriteLine("Cor desconhecida");
            }



            //==================If-else sem chaves (somente 1 linha)=============================
            if (cor == "azul")
                Console.WriteLine("Sua cor favorita é azul");
            else
                Console.WriteLine("Cor desconhecida");



            //==================If-else com chaves=============================
            if (cor == "azul")
            {
                Console.WriteLine("Sua cor favorita é azul");
            }
            else if (cor == "vermelho")
            {
                Console.WriteLine("Sua cor favorita é vermelho");
            }
            else if (cor == "verde")
            {
                Console.WriteLine("Sua cor favorita é verde");
            }
            else
            {
                Console.WriteLine("Cor desconhecida");
            }



            //==================If-else sem chaves (somente 1 linha)=============================
            if (cor == "azul")
                Console.WriteLine("Sua cor favorita é azul");
            else if (cor == "vermelho")
                Console.WriteLine("Sua cor favorita é vermelho"); 
            else if (cor == "verde")
                Console.WriteLine("Sua cor favorita é verde");
            else
                Console.WriteLine("Cor desconhecida");



            //==================If ternário=============================
            string texto = cor == "azul" ? "Sua cor favorita é azul" : "Cor desconhecida";
            Console.WriteLine(texto);

            Console.ReadKey();
        }
    }
}