using System;

namespace Comentarios_Var
{
    class Program
    {
        static void Main(string[] args)
        {
            //Comentário inline
            //Tipagem explicita
            int inteiro1 = 1;
            double double1 = 1.5;
            string string1 = "Minha string 1";

            //Comentário inline
            //Tipagem implicita
            var inteiro2 = 2;
            var double2 = 2.5;
            var string2 = "Minha string 2";

            /* 
            var inteiro3 = 3;
            var double3 = 3.5;
            var string3 = "Minha string 3";
            */

            /* 
            Comentário multi-line
            Vamos imprimir os valores das variáveis
            */

            Console.WriteLine(inteiro1);
            Console.WriteLine(double1);
            Console.WriteLine(string1);
            Console.WriteLine();
            Console.WriteLine(inteiro2);
            Console.WriteLine(double2);
            Console.WriteLine(string2);

            Console.ReadKey();
        }
    }
}