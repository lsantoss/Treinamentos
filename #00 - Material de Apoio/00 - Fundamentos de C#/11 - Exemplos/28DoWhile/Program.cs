using System;

namespace _28DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            bool perguntarNomente;

            do
            {
                Console.WriteLine();
                Console.Write("Digite o login: ");
                string login = Console.ReadLine();

                Console.Write("Digite a senha: ");
                string senha = Console.ReadLine();

                if (login == "admin" && senha == "123")
                {
                    perguntarNomente = false;
                }
                else
                {
                    perguntarNomente = true;
                    Console.WriteLine("Login e/ou senha incorretos!");
                }
            }
            while (perguntarNomente);

            Console.WriteLine("Usuário logado com sucesso!");
            Console.ReadKey();
        }
    }
}