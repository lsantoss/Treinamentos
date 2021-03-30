using System;

namespace _23For
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite quantas vezes quer repetir: ");
            int numeroVezes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("======= For em uma linha ======== ");
            for (int i = 0; i < numeroVezes; i++)
                Console.WriteLine(i);

            Console.WriteLine();
            Console.WriteLine("======= For com chaves ======== ");
            for (int i = 0; i < numeroVezes; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}