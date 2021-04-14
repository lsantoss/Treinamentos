using System;

namespace _44Exceptions
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
                //tratar o erro
                //logar em memória
                //logar em xml
                //logar em uma base de dados
                //enviar um email
                //lançar uma Exception
                throw e;
            }

            Console.ReadKey();
        }
    }
}