using System;

namespace Exemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite quantas vezes quer repetir: ");
            int numeroVezes = Convert.ToInt32(Console.ReadLine());

            //====== For (somente uma linha) ======
            for (int i = 0; i < numeroVezes; i++)
                Console.WriteLine(i);

            //====== For (somente uma linha) ======
            for (int i = 0; i < numeroVezes; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
