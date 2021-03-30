namespace PolimorfismoHerancaVirtuais
{
    public class Veiculo
    {
        public string Tipo { get; set; }

        public Veiculo(string tipoVeiculo)
        {
            Tipo = tipoVeiculo;
        }

        public virtual void Mover() { }

        public virtual void Parar() { }
    }
}