using System;

namespace _55PolimorfismoHerancaVirtuais
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo[] veiculo = new Veiculo[2];

            veiculo[0] = new Automovel("Ferrari");
            veiculo[1] = new Aeronave("Tucano");

            MovimentarVeiculo(veiculo[0]);
            MovimentarVeiculo(veiculo[1]);
            Console.ReadKey();
        }

        public static void MovimentarVeiculo(Veiculo veiculo)
        {
            Console.WriteLine();
            Console.WriteLine(veiculo.Tipo);
            veiculo.Mover();
        }
    }
}