using System;

namespace PolimorfismoHerancaVirtuais
{
    public class Automovel : Veiculo
    {
        public Automovel(string tipoVeiculo) : base(tipoVeiculo) { }

        public override void Mover() => Console.WriteLine("Acelerando o veículo");

        public override void Parar() => Console.WriteLine("Estou brecando o veículo.");
    }
}