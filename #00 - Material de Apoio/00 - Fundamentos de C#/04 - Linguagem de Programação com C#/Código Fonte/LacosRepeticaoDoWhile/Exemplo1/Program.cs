using System;

namespace Exemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a número de repetições: ");
            int numeroRepeticoes = Convert.ToInt32(Console.ReadLine());

            int contador = 0;
            do
            {
                Console.WriteLine(contador);
                contador++;
            } while (contador < numeroRepeticoes);

            Console.ReadKey();
        }
    }
}
