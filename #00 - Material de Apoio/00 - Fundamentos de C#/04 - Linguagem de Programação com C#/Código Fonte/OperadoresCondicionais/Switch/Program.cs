using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite sua cor favorita: ");
            string cor = Console.ReadLine();

            //==================Switch uma condição=============================
            switch (cor)
            {
                case "azul":
                    Console.WriteLine("Sua cor favorita é azul");
                    break;
            }



            //==================Switch uma condição + padrão=============================
            switch (cor)
            {
                case "azul":
                    Console.WriteLine("Sua cor favorita é azul");
                    break;
                default:
                    Console.WriteLine("Cor desconhecida");
                    break;
            }



            //==================Switch várias condição + padrão=============================
            switch (cor)
            {
                case "azul":
                    Console.WriteLine("Sua cor favorita é azul");
                    break;
                case "vermelho":
                    Console.WriteLine("Sua cor favorita é vermelho");
                    break;
                case "verde":
                    Console.WriteLine("Sua cor favorita é verde");
                    break;
                default:
                    Console.WriteLine("Cor desconhecida");
                    break;
            }



            //==================Switch várias condição + padrão=============================
            switch (cor)
            {
                case "azul":
                case "vermelho":
                case "verde":
                case "preto":
                    Console.WriteLine("Eu tamém gosto dessa cor");
                    break;
                case "amarelo":
                case "roxo":
                case "prata":
                    Console.WriteLine("Eu não gosto dessa cor");
                    break;
                default:
                    Console.WriteLine("Cor desconhecida");
                    break;
            }

            Console.ReadKey();
        }
    }
}