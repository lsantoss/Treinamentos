using System;

namespace OperadoresAritimericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------Incremento pós-fixado----------");
            int numero1 = 1;
            Console.WriteLine(numero1);
            Console.WriteLine(numero1++);
            Console.WriteLine(numero1);

            Console.WriteLine();
            Console.WriteLine("----------Incremento prefixado----------");
            int numero2 = 2;
            Console.WriteLine(numero2);
            Console.WriteLine(++numero2);
            Console.WriteLine(numero2);

            Console.WriteLine();
            Console.WriteLine("----------Decremento pós-fixado----------");
            int numero3 = 3;
            Console.WriteLine(numero3);
            Console.WriteLine(numero3--);
            Console.WriteLine(numero3);

            Console.WriteLine();
            Console.WriteLine("----------Decremento prefixado----------");
            int numero4 = 4;
            Console.WriteLine(numero4);
            Console.WriteLine(--numero4);
            Console.WriteLine(numero4);

            Console.WriteLine();
            Console.WriteLine("----------Unário de adição e subtração----------");
            int numero5 = 5;
            Console.WriteLine(numero5);
            Console.WriteLine(+numero5);
            Console.WriteLine(-numero5);

            Console.WriteLine();
            Console.WriteLine("----------Adição----------");
            Console.WriteLine(8 + 8);
            Console.WriteLine(8.5 + 2.8);

            Console.WriteLine();
            Console.WriteLine("----------Subtração----------");
            Console.WriteLine(15 - 3);
            Console.WriteLine(15.3 - 3.3);

            Console.WriteLine();
            Console.WriteLine("----------Multiplicação----------");
            Console.WriteLine(5 * 6);
            Console.WriteLine(2.5 * 6.1);

            Console.WriteLine();
            Console.WriteLine("----------Divisão----------");
            Console.WriteLine(80 / 8);
            Console.WriteLine(20 / 2.5);

            Console.WriteLine();
            Console.WriteLine("----------Resto----------");
            Console.WriteLine(80 % 8);
            Console.WriteLine(5 % 2);

            Console.WriteLine();
            Console.WriteLine("----------Atribuição composta----------");
            int numero6 = 6;
            Console.WriteLine(numero6 += 2);
            numero6 = 6;
            Console.WriteLine(numero6 -= 2);
            numero6 = 6;
            Console.WriteLine(numero6 *= 2);
            numero6 = 6;
            Console.WriteLine(numero6 /= 2);

            Console.WriteLine();
            Console.WriteLine("----------Precedência----------");
            Console.WriteLine(2 + 8 * 5);
            Console.WriteLine(2 + 8 / 2);
            Console.WriteLine((2 + 8) * 5);
            Console.WriteLine((2 + 8) / 2);



            Console.ReadKey();
        }
    }
}