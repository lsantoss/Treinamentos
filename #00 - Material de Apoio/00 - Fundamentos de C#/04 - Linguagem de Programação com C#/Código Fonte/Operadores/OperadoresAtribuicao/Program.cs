using System;

namespace OperadoresAtribuicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------- Atribuição =  -----------------------");
            int numero1 = 5;
            int numero2 = numero1;
            int numero3 = numero1 = numero2; //int numero3 = (numero1 = numero2);

            Console.WriteLine($"Número 1: {numero1}");
            Console.WriteLine($"Número 2: {numero2}");
            Console.WriteLine($"Número 3: {numero3}");

            Console.WriteLine();
            Console.WriteLine("----------------------- Atribuição ref  -----------------------");
            int[] vetor = new int[3];
            vetor[0] = 0;
            vetor[1] = 0;
            vetor[2] = 0;

            Console.WriteLine(string.Join(" ", vetor));

            ref int itemReferencia = ref vetor[0];
            itemReferencia = 5;
            Console.WriteLine(string.Join(" ", vetor));

            itemReferencia = ref vetor[2];
            itemReferencia = 84;
            Console.WriteLine(string.Join(" ", vetor));

            Console.ReadKey();
        }
    }
}