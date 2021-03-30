using System;

namespace _31Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3,3];

            matriz[0, 0] = 1;
            matriz[0, 1] = 2;
            matriz[0, 2] = 3;

            matriz[1, 0] = 4;
            matriz[1, 1] = 5;
            matriz[1, 2] = 6;

            matriz[2, 0] = 7;
            matriz[2, 1] = 8;
            matriz[2, 2] = 9;

            Console.WriteLine();
            Console.Write(matriz[0, 0] + " ");
            Console.Write(matriz[0, 1] + " ");
            Console.Write(matriz[0, 2] + " ");

            Console.WriteLine();
            Console.Write(matriz[1, 0] + " ");
            Console.Write(matriz[1, 1] + " ");
            Console.Write(matriz[1, 2] + " ");

            Console.WriteLine();
            Console.Write(matriz[2, 0] + " ");
            Console.Write(matriz[2, 1] + " ");
            Console.Write(matriz[2, 2] + " ");

            Console.ReadKey();
        }
    }
}