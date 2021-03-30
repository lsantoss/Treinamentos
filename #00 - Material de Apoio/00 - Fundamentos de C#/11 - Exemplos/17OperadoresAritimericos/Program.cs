using System;

namespace _17OperadoresAritimericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=======  Incremento pós-fixado ======");
            int numero1 = 1;
            Console.WriteLine(numero1);
            Console.WriteLine(numero1++);
            Console.WriteLine(numero1);

            Console.WriteLine("=======  Incremento prefixado ======");
            int numero2 = 1;
            Console.WriteLine(numero2);
            Console.WriteLine(++numero2);
            Console.WriteLine(numero2);

            Console.WriteLine("=======  Decremento pós-fixado ======");
            int numero3 = 5;
            Console.WriteLine(numero3);
            Console.WriteLine(numero3--);
            Console.WriteLine(numero3);

            Console.WriteLine("=======  Decremento prefixado ======");
            int numero4 = 10;
            Console.WriteLine(numero4);
            Console.WriteLine(--numero4);
            Console.WriteLine(numero4);

            Console.WriteLine("=======  Unária adição e subtração ======");
            int numero5 = 8;
            Console.WriteLine(numero5);
            Console.WriteLine(+numero5);
            Console.WriteLine(-numero5);

            Console.WriteLine("=======  Adição, Subtração, Multiplicação, Divisão ======");
            Console.WriteLine(10 + 5);
            Console.WriteLine(15 - 8);
            Console.WriteLine(9 * 2);
            Console.WriteLine(9 / 3);

            Console.WriteLine("=======  Resto ======");
            Console.WriteLine(9 % 3);
            Console.WriteLine(578 % 5);
            Console.WriteLine(9 % 2);

            Console.WriteLine("=======  Atribuição Composta ======");
            var numero6 = 10;
            Console.WriteLine(numero6 += 5);
            numero6 = 10;
            Console.WriteLine(numero6 -= 5);
            numero6 = 10;
            Console.WriteLine(numero6 *= 5);
            numero6 = 10;
            Console.WriteLine(numero6 /= 5);

            Console.WriteLine("=======  Precedência ======");
            Console.WriteLine(2 + 8 * 5);
            Console.WriteLine(2 + 8 / 2);
            Console.WriteLine((2 + 8) * 5);
            Console.WriteLine((2 + 8) / 2);

            Console.ReadKey();
        }
    }
}