using System;

namespace Exemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool perguntarNovamente = true;

            do
            {
                Console.WriteLine();
                Console.Write("Digite o login: ");
                string login = Console.ReadLine();

                Console.Write("Digite a senha: ");
                string senha = Console.ReadLine();

                if (login == "admin" && senha == "123")
                {
                    perguntarNovamente = false;
                }
                else
                {
                    Console.WriteLine("Login e/ou senha incorretos!");
                }
            }
            while (perguntarNovamente);

            Console.WriteLine("Usuário logado com sucesso!");
            Console.ReadKey();
        }
    }
}
