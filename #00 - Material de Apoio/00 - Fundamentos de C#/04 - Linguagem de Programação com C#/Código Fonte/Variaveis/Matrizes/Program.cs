using System;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrizInt = new int[3, 3];

            matrizInt[0, 0] = 1;
            matrizInt[0, 1] = 2;
            matrizInt[0, 2] = 3;

            matrizInt[1, 0] = 4;
            matrizInt[1, 1] = 5;
            matrizInt[1, 2] = 6;

            matrizInt[2, 0] = 7;
            matrizInt[2, 1] = 8;
            matrizInt[2, 2] = 9;

            Console.Write($"{matrizInt[0, 0]} ");
            Console.Write($"{matrizInt[0, 1]} ");
            Console.Write($"{matrizInt[0, 2]} ");
            Console.WriteLine();
            Console.Write($"{matrizInt[1, 0]} ");
            Console.Write($"{matrizInt[1, 1]} ");
            Console.Write($"{matrizInt[1, 2]} ");
            Console.WriteLine();
            Console.Write($"{matrizInt[2, 0]} ");
            Console.Write($"{matrizInt[2, 1]} ");
            Console.Write($"{matrizInt[2, 2]} ");







            Console.ReadKey();
        }
    }
}