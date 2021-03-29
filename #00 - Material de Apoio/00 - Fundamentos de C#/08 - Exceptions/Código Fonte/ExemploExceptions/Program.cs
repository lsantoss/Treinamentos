using System;

namespace ExemploExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 100;
            int numero2 = 0;
            double resultado = 0;

            try
            {
                resultado = numero1 / numero2;
            }
            catch (Exception e)
            {
                //tratar
                //logar erro memória
                //logar erro xml
                //logar erro base dados
                //enviar email
                //lançar Exception
                throw e;
            }

            Console.ReadKey();
        }
    }
}