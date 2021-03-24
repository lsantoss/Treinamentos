using System;

namespace _18OperadoresAtribuicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======== Atribuição = ========");
            int numero1 = 55;
            Console.WriteLine(numero1);

            Console.WriteLine();
            Console.WriteLine("======== Atribuição ref ========");
            int[] vetor = new int[3];
            vetor[0] = 0;
            vetor[1] = 0;
            vetor[2] = 0;
            Console.WriteLine(string.Join(" ", vetor));

            ref int itemReferencia = ref vetor[0];
            itemReferencia = 5;
            Console.WriteLine(string.Join(" ", vetor));

            itemReferencia = ref vetor[2];
            itemReferencia = 855;
            Console.WriteLine(string.Join(" ", vetor));

            Console.WriteLine("======== União nula ========");
            int? numNull = null;
            int numero2 = numNull ??= 8;
            Console.WriteLine(numero2);

            Console.ReadKey();
        }
    }
}
