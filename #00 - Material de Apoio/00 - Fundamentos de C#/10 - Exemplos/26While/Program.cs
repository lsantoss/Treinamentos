using System;

namespace _26While
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;

            Console.Write("Digite o número de repetições: ");
            int numeroRepeticoes = Convert.ToInt32(Console.ReadLine());

            while (contador < numeroRepeticoes)
            {
                Console.WriteLine(contador);
                contador++;
            }
            
            Console.ReadKey();
        }
    }
}