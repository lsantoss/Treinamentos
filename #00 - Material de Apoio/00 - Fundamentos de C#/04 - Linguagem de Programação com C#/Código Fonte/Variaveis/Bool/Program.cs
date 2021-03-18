using System;

namespace Bool
{
    class Program
    {
        static void Main(string[] args)
        {
            //valor padrão = false; não pode ser null
            bool valorPadrao;

            Console.Write("Você é rico? ");
            bool souRico = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Você está com fome? ");
            bool estouComFome = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine($"O Lucas é rico?       : {souRico}");
            Console.WriteLine($"O Lucas está com fome?: {estouComFome}");
            Console.ReadKey();
        }
    }
}