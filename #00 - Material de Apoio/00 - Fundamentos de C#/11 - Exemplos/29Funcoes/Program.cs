using System;

namespace _29Funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            ImprimirMenu();
            int operacao = LerOperacao();
            double numero1 = LerDouble();
            double numero2 = LerDouble();
            double resultado = Calcular(operacao, numero1, numero2);

            Console.WriteLine($"O resultado é: {resultado}");
            Console.ReadKey();
        }

        private static void ImprimirMenu()
        {
            Console.WriteLine();
            Console.WriteLine("=========== Menu ===========");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine();
        }

        private static int LerOperacao()
        {
            Console.Write("Escolha a operação: ");
            int operacao = Convert.ToInt32(Console.ReadLine());
            return operacao;
        }

        private static double LerDouble()
        {
            Console.Write("Digite um número: ");
            double numero = Convert.ToDouble(Console.ReadLine());
            return numero;
        }

        private static double Calcular(int operacao, double numero1, double numero2)
        {
            double resultado = 0;

            switch (operacao)
            {
                case 1:
                    resultado = numero1 + numero2;
                    break;
                case 2:
                    resultado = numero1 - numero2;
                    break;
                case 3:
                    resultado = numero1 * numero2;
                    break;
                case 4:
                    resultado = numero1 / numero2;
                    break;
                default:
                    Console.WriteLine("Operação inválida!");
                    break;
            }

            return resultado;
        }
    }
}