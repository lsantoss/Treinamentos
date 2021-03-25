using System;

namespace _22Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("===== Switch com uma condição =====");
            switch (numero)
            {
                case 1:
                    Console.WriteLine($"Seu número é {numero}");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("===== Switch com uma condição + padrão =====");
            switch (numero)
            {
                case 1:
                    Console.WriteLine($"Seu número é {numero}");
                    break;
                default:
                    Console.WriteLine($"Número diferente do esperado");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("===== Switch várias condições + padrão =====");
            switch (numero)
            {
                case 1:
                    Console.WriteLine($"Seu número é {numero}");
                    break;
                case 2:
                    Console.WriteLine($"{numero}");
                    break;
                case 3:
                    Console.WriteLine($"Seu número é {numero} - Lucas");
                    break;
                default:
                    Console.WriteLine($"Número diferente do esperado");
                    break;
            }


            Console.WriteLine();
            Console.WriteLine("===== Switch várias condições + padrão =====");
            switch (numero)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine($"Seu número é {numero}");
                    break;
                case 6:
                case 7:
                    Console.WriteLine($"Seu número é {numero} - Lucas");
                    break;
                default:
                    Console.WriteLine($"Número diferente do esperado");
                    break;
            }

            var cor = "azul";
            switch (cor)
            {
                case "azul":
                    Console.WriteLine("Sua cor favorita é azul");
                    break;
                case "preto":
                    Console.WriteLine("Sua cor favorita é preto");
                    break;
                case "amarelo":
                    Console.WriteLine("Sua cor favorita é amarelo");
                    break;
                case "vermelho":
                    Console.WriteLine("Sua cor favorita é vermelho");
                    break;
                default:
                    Console.WriteLine("Cor desconhecida");
                    break;
            }

            Console.ReadKey();
        }
    }
}